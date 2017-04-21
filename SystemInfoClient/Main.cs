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
        private SystemInfo.SystemInformation _inof = new SystemInfo.SystemInformation();

        public Main()
        {
            InitializeComponent();

            processorSpecyfikationTextBox.DataBindings.Add("Text", _inof.Processor, "Specyfikation");
            processorCoresTextBox.DataBindings.Add("Text", _inof.Processor, "Cores");
            processorLogicalProcessorTextBox.DataBindings.Add("Text", _inof.Processor, "Threds");

            ramTypeTextBox.DataBindings.Add("Text", _inof.Ram, "Type");
            ramCapacityTextBox.DataBindings.Add("Text", _inof.Ram, "Capacity");
        }
    }
}
