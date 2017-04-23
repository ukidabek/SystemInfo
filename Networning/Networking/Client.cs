using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;

namespace Networning
{
    public class Client : NetworkElement
    {
        public void Send(object objectToSend)
        {

            MemoryStream stram = new MemoryStream();
            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(stram, objectToSend);
            stram.Position = 0;
            byte[] x = stram.ToArray();

            _socket.Connect(IP);
            _socket.Send(x);
            _socket.Close();
        }
    }
}
