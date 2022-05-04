using Opc.UaFx;
using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace USN_DataLogging
{
    public enum Quality
    {
        Good,
        Bad
    }

    public class TagMeasurement
    {
        public int TagId { get; set; }
        public double Value { get; set; }
        public Quality Quality { get; set; }
        public string Unit { get; set; }
    }

    public class SqlHandler
    {
        private string _connectionString;
        public SqlHandler(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<string> GetSqlOpcItems()
        {
            var itemIds = new List<string>();
            using (var con = new SqlConnection(_connectionString))
            {
                var query = "SELECT ItemId FROM TAG";
                var cmd = new SqlCommand(query, con);
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var itemId = reader["ItemId"].ToString();
                        itemIds.Add(itemId);
                    }
                    con.Close();
                }
            }
            return itemIds;
        }

        public void SaveTagMeasurement(TagMeasurement tagMeasurement)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SaveTagMeasurement", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TagId", tagMeasurement.TagId));
                cmd.Parameters.Add(new SqlParameter("@Value", tagMeasurement.Value));
                cmd.Parameters.Add(new SqlParameter("@Quality", tagMeasurement.Quality.ToString()));
                cmd.Parameters.Add(new SqlParameter("@Unit", tagMeasurement.Unit));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //public void GetTriggeredAlarms()
        //{
        //    var itemIds = new List<string>();
        //    using (var con = new SqlConnection(_connectionString))
        //    {
        //        var query = "SELECT ItemId FROM TAG";
        //        var cmd = new SqlCommand(query, con);
        //        con.Open();
        //        using (var reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var itemId = reader["ItemId"].ToString();
        //                itemIds.Add(itemId);
        //            }
        //            con.Close();
        //        }
        //    }
        //    return itemIds;
        //}


        //public void InsertAlarm()
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(_connectionString))
        //        {
        //            SqlCommand cmd = new SqlCommand("CreateBook", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add(new SqlParameter("@Title", book.Title));
        //            cmd.Parameters.Add(new SqlParameter("@Isbn", book.Isbn));
        //            cmd.Parameters.Add(new SqlParameter("@PublisherName", book.PublisherName));
        //            cmd.Parameters.Add(new SqlParameter("@AuthorName", book.AuthorName));
        //            cmd.Parameters.Add(new SqlParameter("@CategoryName", book.CategoryName));
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public void InsertMeasurementData()
        {

        }
    }

    public class AlarmManager
    {
        private List<ConfiguredAlarm> _preConfiguredAlarms => GetPreConfiguredAlarms();
        private Dictionary<Guid, ConfiguredAlarm> _triggeredAlarms = new Dictionary<Guid, ConfiguredAlarm>();
        private SqlHandler _sqlHandler;

        public AlarmManager(SqlHandler sqlHandler)
        {
            _sqlHandler = sqlHandler;
        }

        private ConfiguredAlarm CreatePreConfiguredAlarm(AlarmType alarmType, double value, double deadBandInPercentage)
        {
            var preConfiguredAlarm = new ConfiguredAlarm();
            preConfiguredAlarm.AlarmType = alarmType;
            preConfiguredAlarm.Limit = value;
            preConfiguredAlarm.DeadBandInPercentage = deadBandInPercentage;
            return preConfiguredAlarm;
        }

        public List<ConfiguredAlarm> GetPreConfiguredAlarms()
        {
            var preconfiguredAlarms = new List<ConfiguredAlarm>();

            var temperatureHighAlarm = CreatePreConfiguredAlarm(AlarmType.Hi, 40, 1);
            var temperatureHighHighAlarm = CreatePreConfiguredAlarm(AlarmType.HiHi, 50, 1);
            var temperatureLowAlarm = CreatePreConfiguredAlarm(AlarmType.Lo, 20, 1);
            var temperatureLowLowAlarm = CreatePreConfiguredAlarm(AlarmType.LoLo, 10, 1);

            preconfiguredAlarms.Add(temperatureHighAlarm);
            preconfiguredAlarms.Add(temperatureHighHighAlarm);
            preconfiguredAlarms.Add(temperatureLowAlarm);
            preconfiguredAlarms.Add(temperatureLowLowAlarm);

            return preconfiguredAlarms;
        }

        public bool HiAlarm(ConfiguredAlarm preConfiguredAlarm, double measuredValue) =>
            preConfiguredAlarm.AlarmType == AlarmType.Hi
                    || preConfiguredAlarm.AlarmType == AlarmType.HiHi
                    || preConfiguredAlarm.AlarmType == AlarmType.HiHiHi
                    && preConfiguredAlarm.Limit >= measuredValue
                    && OutsideDeadBand(preConfiguredAlarm.DeadBandInPercentage, measuredValue);

        public bool LoAlarm(ConfiguredAlarm preConfiguredAlarm, double measuredValue) =>
            preConfiguredAlarm.AlarmType == AlarmType.Lo
                    || preConfiguredAlarm.AlarmType == AlarmType.LoLo
                    || preConfiguredAlarm.AlarmType == AlarmType.LoLoLo
                    && preConfiguredAlarm.Limit <= measuredValue
                    && OutsideDeadBand(preConfiguredAlarm.DeadBandInPercentage, measuredValue);

        public bool OutsideDeadBand(double deadBandInPercentage, double measuredValue) =>
            measuredValue >= deadBandInPercentage * measuredValue
                    && measuredValue <= deadBandInPercentage * measuredValue;

        public void CheckForAlarm(double measuredValue)
        {
            foreach (var preConfiguredAlarm in _preConfiguredAlarms)
            {
                if (HiAlarm(preConfiguredAlarm, measuredValue))
                {
                    //_sqlHandler.InsertAlarm();
                    _triggeredAlarms.Add(preConfiguredAlarm.Id, preConfiguredAlarm);
                }
                else if (LoAlarm(preConfiguredAlarm, measuredValue))
                {
                    //_sqlHandler.InsertAlarm();
                    _triggeredAlarms.Add(preConfiguredAlarm.Id, preConfiguredAlarm);
                }
            }
        }
    }

    public class ConfiguredAlarm
    {
        public Guid Id => Guid.NewGuid();
        public AlarmType AlarmType { get; set; }
        public double Limit { get; set; }

        private double _deadBandInPercentage = 1;
        public double DeadBandInPercentage
        {
            get => _deadBandInPercentage;
            set
            {
                if (value > 100)
                {
                    _deadBandInPercentage = 100;
                }
                else if (value < 0)
                {
                    _deadBandInPercentage = 0;
                }
                else
                {
                    _deadBandInPercentage = value;
                }
            }
        }
    }

    public class Alarm
    {

    }

    public enum AlarmType
    {
        HiHiHi,
        HiHi,
        Hi,
        Lo,
        LoLo,
        LoLoLo
    }

    class Program
    {
        public static OpcClient GetOpcClient()
        {
            var opcHostName = ConfigurationManager.AppSettings["opcHostName"];
            var opcClient = new OpcClient(opcHostName);
            opcClient.Security.UserIdentity = new OpcClientIdentity("usn_system_user", "usn.password!");
            opcClient.SessionName = "DataLogging application";
            return opcClient;
        }

        static async Task Main(string[] args)
        {
            await Task.Delay(2000);

            // Get application settings.
            var connectionString = ConfigurationManager.AppSettings["connectionString"];
            var measurementSite = ConfigurationManager.AppSettings["measurementSite"];

            // Connect to OPC client.
            var opcClient = GetOpcClient();
            opcClient.Connect();

            var sqlHandler = new SqlHandler(connectionString);
            var alarmManager = new AlarmManager(sqlHandler);

            var opcNodes = opcClient.BrowseNode($"ns=2;s=MeasurementSites/{measurementSite}");
            var sqlItemIds = sqlHandler.GetSqlOpcItems();

            foreach (var child in opcNodes.Children(OpcNodeCategory.Variable))
            {
                foreach (var itemId in sqlItemIds)
                {
                    if (child.NodeId == itemId)
                    {
                        var tagId = 1;
                        Console.WriteLine($"Match between sql itemid and OPC server itemid for {itemId}. Creating seperate task for storing measurement data.");
                        Task.Run(async () => await StoreMeasurementDataAndListenToAlarms(sqlHandler, alarmManager, tagId));
                    }
                }

            }
            Console.ReadLine();
        }

        public static async Task StoreMeasurementDataAndListenToAlarms(SqlHandler sqlHandler, AlarmManager alarmManger, int sqlTagId)
        {
            while (true)
            {
                // insert measurement data into db.
                Console.WriteLine($"Inserting data for tagId: {sqlTagId}");
                var tagMeasurement = new TagMeasurement();
                tagMeasurement.TagId = sqlTagId;
                tagMeasurement.Value = 15;
                tagMeasurement.Quality = Quality.Good;
                tagMeasurement.Unit = "Celsius";
                sqlHandler.SaveTagMeasurement(tagMeasurement);
                Console.WriteLine($"Inserted data for tagId: {sqlTagId}");

                // check alarms
                Console.WriteLine($"Checking for alarms...");
                alarmManger.CheckForAlarm(tagMeasurement.Value);
                Console.WriteLine($"Checked for alarms.");
                await Task.Delay(1000);
            }
        }
    }
}
