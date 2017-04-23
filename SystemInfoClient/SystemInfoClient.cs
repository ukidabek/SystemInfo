using System;
using System.Windows.Forms;
using Networning;

namespace SystemInfoClient
{
    internal static class SystemInfoClient
    {
        private static SystemInfo.SystemInformation _info = new SystemInfo.SystemInformation();
        private static ServerAdressConfig _serverAdress = null;
        private static Client _client = new Client();

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _serverAdress = ServerAdressConfig.LoadConfig(ServerAdressConfig.Server_Adress_Congig_File_Name);

            Main newMainWindow = new Main(_info, _serverAdress,_client);
            Application.Run(newMainWindow);
        }
    }
}