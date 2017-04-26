using System;
using System.Windows.Forms;
using Networning;
using SystemInfo;

namespace SystemInfoServer
{
    internal static class SystemInfoServer
    {
        private static Server _server = new Server();
        private static SystemInformationContainer _container = new SystemInformationContainer();
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _server.Initialize();
            Application.Run(new Dashbord(_server, _container));
        }
    }
}