using Opc.UaFx;
using Opc.UaFx.Server;
using System.Threading;

namespace USN_OPC_UA_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var parent = new OpcFolderNode("USN");
            var temperature = new OpcDataVariableNode<double>(parent, "temperature");
            var controlSignal = new OpcDataVariableNode<double>(parent, "controlSignal");

            using (var server = new OpcServer("opc.tcp://localhost:4840/", parent))
            {
                server.Start();

                while (true)
                {
                    parent.ApplyChanges(server.SystemContext);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
