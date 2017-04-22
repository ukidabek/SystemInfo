using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    public class NetworkAdapterInformation : SystemComponentInformation
    {
        protected override string ComponentCode { get { return "Win32_NetworkAdapterConfiguration"; } }

        protected override void GetComponet()
        {
            ManagementObjectCollection managmentObjects = ManagementClass.GetInstances();
            foreach (ManagementObject item in managmentObjects)
            {
                NetworkAdapter mbo = new NetworkAdapter(item);
                _componets.Add(mbo);
            }
        }
    }
}
