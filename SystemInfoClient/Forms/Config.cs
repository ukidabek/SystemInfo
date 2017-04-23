using System;
using System.Windows.Forms;

namespace SystemInfoClient
{
    public partial class Config : Form
    {
        private string path = string.Empty;
        private ServerAdressConfig serverAdress = null;

        public Config(ServerAdressConfig config, string path)
        {
            InitializeComponent();
            this.path = path;
            this.serverAdress = config;

            ip.DataBindings.Add("Text", serverAdress, "IP");
            port.DataBindings.Add("Text", serverAdress, "Port");
            name.DataBindings.Add("Text", serverAdress, "Name");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            ServerAdressConfig.SaveConfig(path, serverAdress);
            this.Close();
        }
    }
}