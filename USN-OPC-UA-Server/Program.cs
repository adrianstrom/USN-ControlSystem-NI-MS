using Opc.UaFx;
using Opc.UaFx.Server;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace USN_OPC_UA_Server
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var root = new OpcFolderNode("MeasurementSites");
            var locationUSN = new OpcFolderNode(root, "USN");
            var temperature = new OpcDataVariableNode<double>(locationUSN, "Temperature");
            var controlSignal = new OpcDataVariableNode<double>(locationUSN, "ControlSignal");
            var opcHostName = ConfigurationManager.AppSettings["opcHostAddress"];

            using (var server = new OpcServer(opcHostName, root))
            {
                var acl = server.Security.UserNameAcl;
                acl.AddEntry("usn_system_user", "usn.password!");
                acl.IsEnabled = true;
                server.Start();

                server.SessionCreated += SessionCreated;

                while (true)
                {
                    Console.WriteLine($"[OPC UA Server] [{DateTime.UtcNow}] {temperature.Id}: {temperature.Value}");
                    Console.WriteLine($"[OPC UA Server] [{DateTime.UtcNow}] {controlSignal.Id}: {controlSignal.Value}");
                    temperature.ApplyChanges(server.SystemContext);
                    root.ApplyChanges(server.SystemContext);
                    await Task.Delay(1000);
                }
            }
        }

        private static void SessionCreated(object sender, OpcSessionEventArgs e)
        {
            Console.WriteLine($"[OPC UA Server] [{e.Session.ConnectTime}] Session created for {e.Session?.Name ?? "session name not specified"}.");
        }
    }
}
