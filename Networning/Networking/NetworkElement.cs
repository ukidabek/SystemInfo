using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Networning
{
    public class NetworkElement
    {
        public AddressFamily AddressFamily = AddressFamily.InterNetwork;
        public SocketType SocketType = SocketType.Stream;
        public ProtocolType ProtocolType = ProtocolType.Tcp;

        public string IPAdress = string.Empty;
        public int Port = 7777;
        protected IPEndPoint _ip = null;
        public IPEndPoint IP
        {
            get
            {
                if (string.IsNullOrEmpty(IPAdress))
                {
                    IPHostEntry x = Dns.GetHostEntry(Dns.GetHostName());
                    for (int i = 0; i < x.AddressList.Length; i++)
                    {
                        if (x.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                        {
                            _ip = new IPEndPoint(x.AddressList[i], Port);
                            break;
                        }
                    }
                }
                else
                {
                    _ip = new IPEndPoint(IPAddress.Parse(IPAdress), Port);
                }

                return _ip;
            }
        }

        protected Socket _socket = null;

        public void Initialize()
        {
            _socket = new Socket(AddressFamily, SocketType, ProtocolType);
        }
    }
}
