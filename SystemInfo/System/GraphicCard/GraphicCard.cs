using System;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    public class GraphicCard : SystemComponent
    {
        private string _manufacturer = string.Empty;

        public string Manufacturer
        {
            get { return _manufacturer; }
        }

        private string _model = string.Empty;

        public string Model
        {
            get { return _model; }
        }

        private float _memory = 0;

        public float Memory
        {
            get { return _memory; }
        }

        public override string Informatioin
        {
            get { return string.Format("{2} {0} {1}GB", _model, _memory, _manufacturer); }
        }

        public GraphicCard(ManagementObject managementObject) : base(managementObject)
        {
            _manufacturer = managementObject.Properties["AdapterCompatibility"].Value.ToString();
            _model = managementObject.Properties["VideoProcessor"].Value.ToString();
            long ramCapacity = Convert.ToInt64(managementObject.Properties["AdapterRAM"].Value);
            _memory = Units.BitesToGigabites(ramCapacity);
        }
    }
}