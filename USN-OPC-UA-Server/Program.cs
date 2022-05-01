﻿using Opc.UaFx;
using Opc.UaFx.Server;
using System;
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
                var acl = server.Security.UserNameAcl;
                acl.AddEntry("usn_system_user", "usn.password!");
                acl.IsEnabled = true;
                server.Start();

                server.SessionCreated += SessionCreated;

                while (true)
                {
                    Console.WriteLine($"{temperature.Id}: {temperature.Value}");
                    Console.WriteLine($"{controlSignal.Id}: {controlSignal.Value}");
                    temperature.ApplyChanges(server.SystemContext);
                    parent.ApplyChanges(server.SystemContext);
                    Thread.Sleep(1000);
                }
            }
        }

        private static void SessionCreated(object sender, OpcSessionEventArgs e)
        {
            Console.WriteLine($"[{e.Session.ConnectTime}] Session created.");
        }
    }
}
