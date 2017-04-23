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
        static readonly object _conectionsLocker = new object();

        private Thread _clientsHandlingThred = null;
        private Thread _conectionHandlingThred = null;


        private List<Conection> _conections = new List<Conection>();

        public Action<string> GenerateLogAction;
        public Action<byte[]> DataReceivedAction;
   

        public void StartServer()
        {
             _socket.Bind(IP);
            _socket.Listen(30);

            _clientsHandlingThred = new Thread(HandleClients);
            _clientsHandlingThred.Start();

            _conectionHandlingThred = new Thread(ConectionsHandling);
            _conectionHandlingThred.Start();
        }

        public void StopServer()
        {
            _clientsHandlingThred.Abort();
            _conectionHandlingThred.Abort();
        }

        public void HandleClients()
        {
            while(true)
            {
                Socket clientSocket = _socket.Accept();

                string newConectionLog = string.Format("New conection form ip: {0}.\r\n", clientSocket.RemoteEndPoint.ToString());
                GenerateLogAction?.Invoke(newConectionLog);

                lock(_conectionsLocker)
                {
                    _conections.Add(new Conection(clientSocket));
                }
            }
        }

        public void ConectionsHandling()
        {
            while (true)
            {
                lock (_conectionsLocker)
                {
                    for (int i = 0; i < _conections.Count; i++)
                    {
                        _conections[i].Receive();
                        if(_conections[i].EndOfTransmision)
                        {
                            DataReceivedAction?.Invoke(_conections[i].Data);
                            string newConectionLog = string.Format("Conection form ip: {0} closed.\r\n", _conections[i].EndPointIp);
                            GenerateLogAction?.Invoke(newConectionLog);

                            _conections[i].Close();
                            _conections.RemoveAt(i);
                           --i;
                        }
                    }
                }
                Thread.Sleep(100);
            }
        }
    }
}
