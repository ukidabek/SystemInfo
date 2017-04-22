using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace SystemInfo
{
    public abstract class SystemComponentInformation
    {
        protected abstract string ComponentCode { get; }

        private ManagementClass managementClass = null;
        protected ManagementClass ManagementClass
        {
            get
            {
                if (managementClass == null)
                {
                    managementClass = new ManagementClass(ComponentCode);
                }

                return managementClass;
            }
        }

        protected List<SystemComponent> _componets = new List<SystemComponent>();
        public List<SystemComponent> Componets
        {
            get { return _componets; }
        }

        public abstract string Informatioin { get; }

        public SystemComponentInformation()
        {
            GetComponet();
        }

        protected abstract void GetComponet();
    }
}
