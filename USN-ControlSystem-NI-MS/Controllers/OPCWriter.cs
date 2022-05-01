using Opc.UaFx.Client;

namespace USN_ControlSystem_NI_MS.Controllers
{
    public class OPCClient
    {
        private OpcClient _client;

        public OPCClient(string hostName)
        {
            _client = new OpcClient(hostName);
        }

        public void WriteValues()
        {
            using (var client = new OpcClient("opc.tcp://localhost:4840"))
            {
                client.Connect();

                var temperature = client.ReadNode("ns=2;s=Temperature");
                //var controlSignal = client.ReadNode("ns=2;s=ControlSignal");
            }
        }
    }
}
