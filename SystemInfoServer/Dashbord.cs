using System.Windows.Forms;
using Networning;

namespace SystemInfoServer
{
    public partial class Dashbord : Form
    {
        private delegate void SetTextCallback(string text);

        private Server _server = null;
        private SystemInformationContainer _container = null;

        public Dashbord(Server server, SystemInformationContainer container)
        {
            _server = server;
            _server.GenerateLogAction -= Log;
            _server.GenerateLogAction += Log;

            _container = container;
            _container.GenerateLogAction -= Log;
            _container.GenerateLogAction += Log;

            _server.DataReceivedAction -= _container.GetSystemInfo;
            _server.DataReceivedAction += _container.GetSystemInfo;

            server.StartServer();

            InitializeComponent();

        }

        public void Log(string log)
        {

            if (InvokeRequired)
            {
                SetTextCallback a = new SetTextCallback(Log);
                this.Invoke(a, new object[] { log });
            }
            else
            {
                this.log.Text += log;
            }

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            _container.GenerateCSV();
        }

    }
}