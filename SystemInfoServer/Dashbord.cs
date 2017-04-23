using System.Windows.Forms;
using Networning;

namespace SystemInfoServer
{
    public partial class Dashbord : Form
    {
        private Server _server = null;

        public Dashbord(Server server)
        {
            _server = server;
            server.StartServer();

            InitializeComponent();
        }
    }
}