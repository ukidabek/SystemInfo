using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfo
{
    [Serializable]
    public class SystemInformation
    {
        private List<SystemComponent> _componets = new List<SystemComponent>();

        private Processor _processor = new Processor();
        public Processor Processor
        {
            get { return _processor; }
        }

        private Ram _ram = new Ram();
        public Ram Ram
        {
            get { return _ram; }
        }

        public SystemInformation()
        {
            _componets.Add(_processor);
            _componets.Add(_ram);

            for (int i = 0; i < _componets.Count; i++)
            {
                SystemComponent componet = _componets[i];
                componet.GetComponentInfo();
            }
        }
    }
}
