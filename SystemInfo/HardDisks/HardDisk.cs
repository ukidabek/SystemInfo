using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfo
{
    [Serializable]
    class HardDisk : SystemComponent
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

        public HardDisk(ManagementObject managementObject) : base(managementObject)
        {
            //string a = string.Empty;
            //foreach (PropertyData item in managementObject.Properties)
            //{
            //    if (item.Value == null)
            //        continue;

            //    a += string.Format("{0} {1}\r\n", item.Name, item.Value.ToString());
            //}

            //int aa = 5;

            _model = managementObject.Properties["Model"].Value.ToString();
            long size = Convert.ToInt64(managementObject.Properties["Size"].Value);
            _size = Units.BitesToGigabites(size);
        }
    }
}
