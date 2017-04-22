using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace SystemInfo
{
    public abstract class SystemComponent
    {
        public abstract string Informatioin { get; }

        public SystemComponent(ManagementObject managementObject) {}
    }
}
