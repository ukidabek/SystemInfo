using System;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    public class Motherboard : SystemComponent
    {
        private string _manufacturer = string.Empty;

        public string Manufacturer
        {
            get { return _manufacturer; }
        }

        private string _product = string.Empty;

        public string Product
        {
            get { return _product; }
        }

        public override string Informatioin
        {
            get { return string.Format("{0} {1}\r\n", _manufacturer, _product); }
        }

        public override string CSVInformatioin
        {
            get { return string.Format("{0} {1}", _manufacturer, _product); }
        }

        public Motherboard(ManagementObject managementObject) : base(managementObject)
        {
            _manufacturer = managementObject.Properties["Manufacturer"].Value.ToString();
            _product = managementObject.Properties["Product"].Value.ToString();
        }
    }
}