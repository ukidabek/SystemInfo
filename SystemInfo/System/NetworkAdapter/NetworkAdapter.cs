using System;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    public class NetworkAdapter : SystemComponent
    {
        private string _name = string.Empty;

        public string Name
        {
            get { return _name; }
        }

        private string _netConnectionID = string.Empty;

        public string NetConnectionID
        {
            get { return _netConnectionID; }
        }

        public override string Informatioin
        {
            get { return string.Format("{0} {1}\r\n", _name, _netConnectionID); }
        }

        public NetworkAdapter(ManagementObject managementObject) : base(managementObject)
        {
            string a = Utilities.GetAllPropertisInfo(managementObject);
            _name = managementObject.Properties["ProductName"].Value.ToString();
            _netConnectionID = managementObject.Properties["NetConnectionID"].Value.ToString();
        }
    }
}