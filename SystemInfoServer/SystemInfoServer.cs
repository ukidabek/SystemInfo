using System;
using System.Windows.Forms;
using Networning; 

namespace SystemInfoServer
{
    internal static class SystemInfoServer
    {
        private static Server _server = new Server();
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashbord(_server));
        }
    }
}