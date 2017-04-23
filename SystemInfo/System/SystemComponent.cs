using System.Management;
using System;

namespace SystemInfo
{
    [Serializable]
    public abstract class SystemComponent
    {
        public abstract string Informatioin { get; }
        public abstract string CSVInformatioin { get; }


        public SystemComponent(ManagementObject managementObject)
        {
        }
    }
}