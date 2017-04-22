using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace SystemInfo
{
    public static class Utilities
    {
        public static string GetAllPropertisInfo(ManagementObject managementObject)
        {
            string info = string.Empty;
            foreach (PropertyData item in managementObject.Properties)
            {
                if (item.Value == null)
                    continue;

                info += string.Format("{0} {1}\r\n", item.Name, item.Value.ToString());
            }

            return info;
        }
    }
}
