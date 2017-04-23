using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Networning
{
    class Conection
    {
        private Socket _socket;
        private List<byte> _data = new List<byte>();
        private int _bufforSize = 0;

        public byte[] Data
        {
            get { return _data.ToArray(); }
        }

        public bool Connected
        {
            get { return _socket.Connected; }
        }

        private bool _endOfTransmision = false;
        public bool EndOfTransmision
        {
            get { return _endOfTransmision; }
        }


        public Conection(Socket socket, int bufforSize = 1024)
        {
            _socket = socket;
            _bufforSize = bufforSize;
            _socket.Blocking = false;
        }

        public void Receive()
        {
            if (!_socket.Connected)
                return;

            byte[] buffor = new byte[_bufforSize];
            int size =_socket.Receive(buffor);
            if(size > 0)
            {
                for (int i = 0; i < size; i++)
                {
                    _data.Add(buffor[i]);
                }
            }
            else
            {
                _endOfTransmision = true;
            }
        }

        public void Close()
        {
            _socket.Close();
        }

        public string EndPointIp
        {
            get { return _socket.RemoteEndPoint.ToString(); }
        }
    }
}
