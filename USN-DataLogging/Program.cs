using Opc.UaFx;
using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace USN_DataLogging
{
    public class SqlHandler
    {
        private string _connectionString;
        public SqlHandler(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<string> GetSqlOpcItems()
        {
            try
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
            catch (Exception e)
            {
                return null;
            }
        }
    }
    class Program
    {
        public static OpcClient GetOpcClient()
        {
            var opcClient = new OpcClient("opc.tcp://localhost:4840/");
            opcClient.Security.UserIdentity =
                new OpcClientIdentity("usn_system_user", "usn.password!");
            opcClient.SessionName = "DataLogging application";
            return opcClient;
        }

        static async Task Main(string[] args)
        {
            await Task.Delay(2000);
            var connectionString = ConfigurationManager.AppSettings["connectionString"];
            var measurementSite = ConfigurationManager.AppSettings["measurementSite"];
            var opcClient = GetOpcClient();
            opcClient.Connect();

            var sqlHandler = new SqlHandler(connectionString);

            var opcNodes = opcClient.BrowseNode($"ns=2;s=MeasurementSites/{measurementSite}");
            var sqlItemIds = sqlHandler.GetSqlOpcItems();

            foreach (var child in opcNodes.Children(OpcNodeCategory.Variable))
            {
                foreach (var itemId in sqlItemIds)
                {
                    if (child.NodeId == itemId)
                    {
                        Console.WriteLine($"Match between sql itemid and OPC server itemid for {itemId}. Creating seperate task for storing measurement data.");
                        await Task.Run(async () => await StoreMeasurementDataAndListenToAlarms());
                    }
                }

            }
            Console.ReadLine();
        }

        public static async Task StoreMeasurementDataAndListenToAlarms()
        {
            // insert measurement data into db.
        }
    }
}
