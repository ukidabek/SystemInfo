using System.Collections.Generic;
using System.Management;
using System;

namespace SystemInfo
{
    [Serializable]
    public abstract class SystemComponentInformation
    {
        protected abstract string ComponentCode { get; }

        [NonSerialized]
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

        public virtual string Informatioin
        {
            get
            {
                string information = string.Empty;
                for (int i = 0; i < _componets.Count; i++)
                {
                    information += _componets[i].Informatioin;
                }

                return information;
            }
        }

        public SystemComponentInformation()
        {
            GetComponet();
        }

        protected abstract void GetComponet();

        public virtual string ToCSV()
        {
            string csv = string.Empty;
            for (int i = 0; i < _componets.Count; i++)
            {
                csv += string.Format("{0} ", _componets[i].CSVInformatioin);
            }

            return csv;
        }
    }
}