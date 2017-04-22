using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            motherboardInfo.DataBindings.Add("Text", _info.Matherboard, "Informatioin");
            hardDisksInfo.DataBindings.Add("Text", _info.HardDisks, "Informatioin");
            //networkAdapterInfo.DataBindings.Add("Text", _info.NewtworkAdapters, "Informatioin");
            operatingSystemInfo.DataBindings.Add("Text", _info.OperatingSystem, "Informatioin");
        }

        private void sendInfo_Click(object sender, EventArgs e)
        {

        }

        private void config_Click(object sender, EventArgs e)
        {
            Config configuration = new Config();
            configuration.ShowDialog();
        }
    }
}
