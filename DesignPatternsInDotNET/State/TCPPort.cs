using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class TCPPort
    {
        internal ITCPState _tcpState;
        public int PortNumber { get; }

        public TCPPort(int portNumber)
        {
            // initially set the tcp port to open or closed randomly
            var rnd = new Random();
            if (rnd.Next(0, 2) == 1)
            {
                _tcpState = new TCPOpen();
            }
            else
            {
                _tcpState = new TCPClosed();
            }

            PortNumber = portNumber;
        }

        public void Connect()
        {
            _tcpState.HandleConnection(this);
        }
    }
}
