using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Networning
{
    public class Client : NetworkElement
    {
        public void Send(object objectToSend)
        {
            MemoryStream stram = new MemoryStream();

            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(stram, objectToSend);

            byte[] x = stram.ToArray();
            _socket.SendTo(x, IP);
        }
    }
}
