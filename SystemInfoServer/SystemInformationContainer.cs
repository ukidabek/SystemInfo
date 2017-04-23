using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInfo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace SystemInfoServer
{
    public class SystemInformationContainer
    {
        private List<SystemInformation> _systemsInformation = new List<SystemInformation>();
        public Action<string> GenerateLogAction;

        public void GetSystemInfo(byte[] systemInfoData)
        {
            MemoryStream stram = new MemoryStream(systemInfoData);
            BinaryFormatter formatter = new BinaryFormatter();

            object systemInfo = formatter.Deserialize(stram);
            if (systemInfo is SystemInformation)
            {
                SystemInformation _systemInfo = systemInfo as SystemInformation;

                _systemsInformation.Add(_systemInfo);
                GenerateLogAction?.Invoke(string.Format("Infor form {0} added.\r\n", _systemInfo.Owner));
            }
        }

        public void GenerateCSV()
        {
            Stream ratprot = File.Open("raport.csv", FileMode.Create);
            StreamWriter ratprotWriter = new StreamWriter(ratprot);
            for (int i = 0; i < _systemsInformation.Count; i++)
            {
                ratprotWriter.WriteLine(_systemsInformation[i].ToCSV());
            }
            ratprotWriter.Flush();
            ratprotWriter.Close();
            GenerateLogAction?.Invoke("Raport generated.");

        }
    }
}
