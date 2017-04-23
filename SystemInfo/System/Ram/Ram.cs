using System;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    public class Ram : SystemComponent
    {
        private string _bank = string.Empty;

        public string Bank
        {
            get { return _bank; }
        }

        private long _capacity = 0;

        public float Capacity
        {
            get { return Units.BitesToGigabites(_capacity); }
        }

        private RamType _type;

        public RamType Type
        {
            get { return _type; }
        }

        private long _speed = 0;

        public long Speed
        {
            get { return _speed; }
        }

        public override string Informatioin
        {
            get { return string.Format("{0}: {1}GB of {2} runing at {3}Mhz\r\n", Bank, Capacity, Type, Speed); }
        }

        public override string CSVInformatioin
        {
            get { return string.Format("{0}: {1}GB of {2} runing at {3}Mhz", Bank, Capacity, Type, Speed); }
        }

        public static RamType GetRamType(object type)
        {
            long typeID = Convert.ToInt64(type);

            switch (typeID)
            {
                case 24:
                    return RamType.DDR3;

                case 26:
                    return RamType.DDR4;
            }

            return RamType.Unknown;
        }

        public Ram(ManagementObject managementObject)
            : base(managementObject)
        {
            _bank = managementObject.Properties["BankLabel"].Value.ToString();
            _capacity = Convert.ToInt64(managementObject.Properties["Capacity"].Value);
            _type = GetRamType(managementObject.Properties["SMBIOSMemoryType"].Value);
            _speed = Convert.ToInt64(managementObject.Properties["Speed"].Value);
        }
    }
}