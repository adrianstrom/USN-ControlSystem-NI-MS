using Opc.UaFx.Client;

namespace USN_DataLogging
{
    class Program
    {
        private OpcClient _opcClient;

        static void Main(string[] args)
        {
            var opcClient = new OpcClient("opc.tcp://localhost:4840/");
            opcClient.Security.UserIdentity =
                new OpcClientIdentity("usn_system_user", "usn.password!");
            opcClient.Connect();
        }
    }
}
