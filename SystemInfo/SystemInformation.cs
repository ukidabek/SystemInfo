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
        private List<SystemComponentInformation> _componets = new List<SystemComponentInformation>();

        private ProcessorInformation _processor = new ProcessorInformation();
        public ProcessorInformation Processor
        {
            get { return _processor; }
        }

        private RamInformation _ram = new RamInformation();
        public RamInformation Ram
        {
            get { return _ram; }
        }

        private GraphicCardInformation _graphicCard = new GraphicCardInformation();
        public GraphicCardInformation GraphicCard
        {
            get { return _graphicCard; }
        }
    }
}
