using Opc.UaFx;
using Opc.UaFx.Client;
using System;
using System.Configuration;
using System.Threading.Tasks;
using USN_DataLogging.DataTypes;

namespace USN_DataLogging
{

    class Program
    {
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

        public static OpcClient GetOpcClient()
        {
            var opcHostName = ConfigurationManager.AppSettings["opcHostName"];
            var opcClient = new OpcClient(opcHostName);
            opcClient.Security.UserIdentity = new OpcClientIdentity("usn_system_user", "usn.password!");
            opcClient.SessionName = "DataLogging application";
            return opcClient;
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
