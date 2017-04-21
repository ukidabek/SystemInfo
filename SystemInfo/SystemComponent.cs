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
        protected abstract string ComponentCode { get; }

        private ManagementClass managementClass = null;
        protected ManagementClass ManagementClass
        {
            get
            {
                if(managementClass == null)
                {
                    managementClass = new ManagementClass(ComponentCode);
                }

                return managementClass;
            }
        }

        protected ManagementObjectCollection ManagementObjectCollection
        {
            get { return ManagementClass.GetInstances();}
        }

        public abstract void GetComponentInfo();
    }
}
