using System;
using System.Windows.Forms;

namespace SystemInfoClient
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}