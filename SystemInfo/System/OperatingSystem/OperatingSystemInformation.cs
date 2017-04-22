using System;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    public class OperatingSystemInformation : SystemComponentInformation
    {
        protected override string ComponentCode { get { return "Win32_OperatingSystem"; } }

        protected override void GetComponet()
        {
            ManagementObjectCollection managmentObjects = ManagementClass.GetInstances();
            foreach (ManagementObject item in managmentObjects)
            {
                OperatingSystem os = new OperatingSystem(item);
                _componets.Add(os);
            }
        }
    }
}