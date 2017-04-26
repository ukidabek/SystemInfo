using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInfo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SystemInfo
{
    public class SystemInformationContainer
    {
        private const string System_Info_Data_File_path = "SysInfo.data"; 

        private List<SystemInformation> _systemsInformation = new List<SystemInformation>();
        private List<SystemInfoLink> _links = new List<SystemInfoLink>();

        public Action<string> GenerateLogAction;

        public void GetSystemInfo(byte[] systemInfoData)
        {
            MemoryStream memoryStream = new MemoryStream(systemInfoData);
            BinaryFormatter formatter = new BinaryFormatter();

            object systemInfo = formatter.Deserialize(memoryStream);
            if (systemInfo is SystemInformation)
            {
                SystemInformation _systemInfo = systemInfo as SystemInformation;
                SystemInfoLink link = _links.First(l => l.SystemID == _systemInfo.ID);
                if(link == null)
                {
                    Stream dataFile = File.Open(System_Info_Data_File_path, FileMode.Append);
                    link = new SystemInfoLink(_systemInfo, dataFile.Length);
                    formatter.Serialize(dataFile, _systemInfo);
                    _links.Add(link);
                }
                else
                {

                }
                //_systemsInformation.Add(_systemInfo);
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
