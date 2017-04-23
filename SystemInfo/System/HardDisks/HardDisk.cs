using System;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    public class HardDisk : SystemComponent
    {
        private string _model = string.Empty;

        public string Model
        {
            get { return _model; }
        }

        private float _size = 0f;

        public float Size
        {
            get { return _size; }
        }

        public override string Informatioin
        {
            get { return string.Format("{0} {1}GB\r\n", _model, _size); }
        }

        public override string CSVInformatioin
        {
            get { return string.Format("{0} {1}GB ", _model, _size); }
        }

        public HardDisk(ManagementObject managementObject) : base(managementObject)
        {
            _model = managementObject.Properties["Model"].Value.ToString();
            long size = Convert.ToInt64(managementObject.Properties["Size"].Value);
            _size = Units.BitesToGigabites(size);
        }
    }
}