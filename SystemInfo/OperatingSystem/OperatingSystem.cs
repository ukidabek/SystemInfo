using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    class OperatingSystem : SystemComponent
    {
        private string _caption = string.Empty;
        public string Caption
        {
            get { return _caption; }
        }

        private string _oSArchitecture = string.Empty;
        public string OsArchitecture
        {
            get { return _oSArchitecture; }
        }

        public override string Informatioin
        {
            get { return string.Format("{0} {1}\r\n", _caption, _oSArchitecture); }
        }

        public OperatingSystem(ManagementObject managementObject) : base(managementObject)
        {
            _caption = managementObject.Properties["Caption"].Value.ToString();
            _oSArchitecture = managementObject.Properties["OSArchitecture"].Value.ToString();
        }
    }
}
