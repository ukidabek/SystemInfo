using System;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    public class RamInformation : SystemComponentInformation
    {
        protected override string ComponentCode { get { return "Win32_PhysicalMemory"; } }

        public override string Informatioin
        {
            get
            {
                string information = string.Empty;
                for (int i = 0; i < _componets.Count; i++)
                {
                    information += _componets[i].Informatioin;
                }

                return string.Format("{1}GB of {2} runing at {3}Mhz\r\n{0} ", information, _totalCapacity, _type, _speed);
            }
        }

        private RamType _type = RamType.Unknown;

        private float _totalCapacity = 0f;

        private long _speed = 10000000;

        protected override void GetComponet()
        {
            ManagementObjectCollection managmentObjects = ManagementClass.GetInstances();
            foreach (ManagementObject item in managmentObjects)
            {
                Ram ram = new Ram(item);
                _type = ram.Type;
                _totalCapacity += ram.Capacity;
                _speed = ram.Speed < _speed ? ram.Speed : _speed;
                _componets.Add(ram);
            }
        }

        public override string ToCSV()
        {
            return string.Format("{0}GB of {1} runing at {2}Mhz", _totalCapacity, _type, _speed);
        }
    }
}