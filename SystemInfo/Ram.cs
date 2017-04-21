using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace SystemInfo
{
    public class Ram : SystemComponent
    {
        protected override string ComponentCode { get { return "Win32_PhysicalMemory"; } }

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

        public override void GetComponentInfo()
        {
            foreach (ManagementObject item in ManagementObjectCollection)
            {
                _capacity += Convert.ToInt64(item.Properties["Capacity"].Value);
                _type = GetRamType(item.Properties["SMBIOSMemoryType"].Value);
            }
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
    }
}
