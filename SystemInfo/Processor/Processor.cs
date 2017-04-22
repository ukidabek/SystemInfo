using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    public class Processor : SystemComponent
    {
        private string _deviceID = string.Empty;
        public string DeviceID
        {
            get { return _deviceID; }
        }

        private string _specyfikation = string.Empty;
        public string Specyfikation
        {
            get { return _specyfikation; }
        }

        private long _cores;
        public string Cores
        {
            get { return _cores.ToString(); }
        }

        private long _threds;
        public string Threds
        {
            get { return _threds.ToString(); }
        }

        public override string Informatioin
        {
            get { return string.Format("{0}\r\n", Specyfikation); }
        }

        public Processor(ManagementObject managementObject)
            : base(managementObject)
        {
            _deviceID = managementObject.Properties["DeviceID"].Value.ToString();
            _specyfikation = managementObject.Properties["Name"].Value.ToString();
            _cores = Convert.ToInt64(managementObject.Properties["NumberOfCores"].Value);
            _threds = Convert.ToInt64(managementObject.Properties["NumberOfLogicalProcessors"].Value);
        }
    }
}
