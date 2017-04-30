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
        private const string System_Info_Data_File_Links_path = "SysInfo.link";
        private const string System_Info_Data_File_path = "SysInfo.data";
        private const string System_Info_Tmp_Data_File_path = "TmpSysInfo.data";
        private const string System_Info_Raport = "SysInfoRaport.csv";

        private List<SystemInfoLink> _links = new List<SystemInfoLink>();

        public Action<string> GenerateLogAction;

        public SystemInformationContainer()
        {
            if(File.Exists(System_Info_Data_File_Links_path))
            {
                Stream dataLinksFile = File.Open(System_Info_Data_File_Links_path, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                while(true)
                {
                    object _object = null;

                    if(dataLinksFile.Position == dataLinksFile.Length)
                    {
                        break;
                    }

                    _object = formatter.Deserialize(dataLinksFile);

                    if(_object != null)
                    {
                        SystemInfoLink link = _object as SystemInfoLink;
                        _links.Add(link);
                    }
                }

                dataLinksFile.Close();
            }
        }

        public void GetSystemInfo(byte[] systemInfoData)
        {
            MemoryStream memoryStream = new MemoryStream(systemInfoData);
            BinaryFormatter formatter = new BinaryFormatter();

            object systemInfo = formatter.Deserialize(memoryStream);
            if (systemInfo is SystemInformation)
            {
                SystemInformation _systemInfo = systemInfo as SystemInformation;

                SystemInfoLink link = null;
                link = _links.FirstOrDefault(l => l.SystemID == _systemInfo.ID);

                if(link == null)
                {
                    AddSystemInfo(link, _systemInfo);
                    GenerateLogAction?.Invoke(string.Format("Infor form {0} added.\r\n", _systemInfo.Owner));
                }
                else
                {
                    if(EditSystemInfo(link, _systemInfo, systemInfoData.Length))
                    {
                        GenerateLogAction?.Invoke(string.Format("Infor form {0} modified.\r\n", _systemInfo.Owner));
                    }
                    else
                    {
                        GenerateLogAction?.Invoke(string.Format("Infor form {0} has not changed.\r\n", _systemInfo.Owner));
                    }
                }
            }
        }

        public void GenerateCSV()
        {
            if (File.Exists(System_Info_Data_File_path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream ratprot = File.Open(System_Info_Raport, FileMode.Create);
                Stream dataFile = File.Open(System_Info_Data_File_path, FileMode.Open);
                StreamWriter ratprotWriter = new StreamWriter(ratprot);

                while(true)
                {
                    if (dataFile.Position != dataFile.Length)
                    {
                        object _object = formatter.Deserialize(dataFile);
                        SystemInformation systemInfo = _object as SystemInformation;
                        ratprotWriter.WriteLine(systemInfo.ToCSV());
                    }
                    else
                    {
                        break;
                    }
                }

                ratprotWriter.Flush();
                ratprotWriter.Close();
                dataFile.Close();

                GenerateLogAction?.Invoke("Raport generated.");
            }
        }

        private void AddSystemInfo(SystemInfoLink link, SystemInformation _systemInfo)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            Stream dataFile = File.Open(System_Info_Data_File_path, FileMode.Append);
            link = new SystemInfoLink(_systemInfo, dataFile.Length);
            formatter.Serialize(dataFile, _systemInfo);
            _links.Add(link);
            dataFile.Close();

            Stream dataLinksFile = File.Open(System_Info_Data_File_Links_path, FileMode.Append);
            formatter.Serialize(dataLinksFile, link);
            dataLinksFile.Close();
        }

        private bool EditSystemInfo(SystemInfoLink link, SystemInformation _systemInfo, int length)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            Stream dataFile = File.Open(System_Info_Data_File_path, FileMode.Open);
            dataFile.Position = link.FileStartPoint;
            object _object = formatter.Deserialize(dataFile);
            SystemInformation info = _object as SystemInformation;

            if (info.Hash != _systemInfo.Hash)
            {
                Stream dataTmpFile = File.Open(System_Info_Tmp_Data_File_path, FileMode.OpenOrCreate);

                for (int i = 0; i < link.FileStartPoint; i++)
                {
                    dataTmpFile.WriteByte((byte)dataFile.ReadByte());
                }

                formatter.Serialize(dataTmpFile, _systemInfo);

                for (long i = link.FileStartPoint + length; i < dataFile.Length; i++)
                {
                    dataTmpFile.WriteByte((byte)dataFile.ReadByte());
                }

                dataTmpFile.Close();
                dataFile.Close();

                File.Delete(System_Info_Data_File_path);
                File.Move(System_Info_Tmp_Data_File_path, System_Info_Data_File_path);
                File.Delete(System_Info_Tmp_Data_File_path);

                return true;
            }

            dataFile.Close();

            return false;
        }
    }
}
