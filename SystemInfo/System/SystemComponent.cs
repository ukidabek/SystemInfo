using System.Management;
using System;

namespace SystemInfo
{
    [Serializable]
    public abstract class SystemComponent
    {
        public abstract string Informatioin { get; }

        public SystemComponent(ManagementObject managementObject)
        {
        }
    }
}