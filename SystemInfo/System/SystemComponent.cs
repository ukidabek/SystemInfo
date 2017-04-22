using System.Management;

namespace SystemInfo
{
    public abstract class SystemComponent
    {
        public abstract string Informatioin { get; }

        public SystemComponent(ManagementObject managementObject)
        {
        }
    }
}