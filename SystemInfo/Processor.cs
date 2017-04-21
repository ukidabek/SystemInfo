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
        protected override string ComponentCode { get { return "win32_processor"; } }

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

        public override void GetComponentInfo()
        {
            foreach (ManagementObject item in ManagementObjectCollection)
            {
                _specyfikation = item.Properties["Name"].Value.ToString();
                _cores = Convert.ToInt64(item.Properties["NumberOfCores"].Value);
                _threds = Convert.ToInt64(item.Properties["NumberOfLogicalProcessors"].Value);
            }
        }
    }
}
