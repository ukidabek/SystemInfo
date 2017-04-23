using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Networning
{
    public class Server : NetworkElement, ISentReceive
    {
        private Thread _clientsHandlingThred = null;

        public void StartServer()
        {
             _socket.Bind(IP);

            _clientsHandlingThred = new Thread(HandleClients);
            _clientsHandlingThred.Start();
        }

        public void HandleClients()
        {
            IPEndPoint s = new IPEndPoint(IPAddress.Any, 0);
            EndPoint p = s;
            byte[] x = new byte[1000];
            int z = _socket.ReceiveFrom(x, ref p);
            if(z > 0)
            {
                int a = 4;
            }
        }
    }
}
