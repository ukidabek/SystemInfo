using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    public class GraphicCardInformation : SystemComponentInformation
    {
        protected override string ComponentCode { get { return "Win32_VideoController"; } }

        public override string Informatioin
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

        protected override void GetComponet()
        {
            ManagementObjectCollection managmentObjects = ManagementClass.GetInstances();
            foreach (ManagementObject item in managmentObjects)
            {
                GraphicCard cpu = new GraphicCard(item);
                _componets.Add(cpu);
            }
        }
    }
}
