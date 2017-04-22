using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SystemInfo;


namespace SystemInfoClient
{
    public partial class Main : Form
    {
        private SystemInfo.SystemInformation _info = new SystemInfo.SystemInformation();

        public Main()
        {
            InitializeComponent();

            processorInfo.DataBindings.Add("Text", _info.Processor, "Informatioin");
            ramInfo.DataBindings.Add("Text", _info.Ram, "Informatioin");
            graphicCardInfo.DataBindings.Add("Text", _info.GraphicCard, "Informatioin");
        }
    }
}
