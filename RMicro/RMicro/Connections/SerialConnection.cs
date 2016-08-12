using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMicro.Connections
{
    /// <summary>
    /// A connection through a serial port
    /// </summary>
    class SerialConnection : ITwoWayChannel
    {
        
        public SerialConnection(SerialPort port)
        {

        }

        public byte[] ReceiveBytes()
        {
            throw new NotImplementedException();
        }

        public byte[] ReceiveBytes(int length)
        {
            throw new NotImplementedException();
        }

        public void SendBytes(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
