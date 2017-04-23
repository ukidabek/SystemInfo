using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SystemInfoClient
{
    [Serializable]
    public class ServerAdressConfig
    {
        public const string Server_Adress_Congig_File_Name = "serverAdress.conf";

        private string _ip = "0.0.0.0";
        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }

        private int _port = 0;
        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        private string _name = "User";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public static ServerAdressConfig LoadConfig(string path)
        {
            ServerAdressConfig serverAdress = null;
            if (!File.Exists(path))
            {
                serverAdress = new ServerAdressConfig();
                SaveConfig(path, serverAdress);
                return serverAdress;
            }

            BinaryFormatter formatter = new BinaryFormatter();
            Stream networkConfigFile = File.Open(
                 path,
                 FileMode.Open);

            serverAdress = (ServerAdressConfig)formatter.Deserialize(networkConfigFile);
            networkConfigFile.Close();

            return serverAdress;
        }

        public static void SaveConfig(string path, ServerAdressConfig serverAdress)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream networkConfigFile = File.Open(
                        path,
                        FileMode.Create);

            formatter.Serialize(networkConfigFile, serverAdress);
            networkConfigFile.Close();
        }
    }
}