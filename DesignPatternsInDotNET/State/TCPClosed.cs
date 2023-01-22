using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class TCPClosed : ITCPState
    {
        public void HandleConnection(TCPPort context)
        {
            Console.WriteLine($"Cannot connect to port {context.PortNumber}. Port is closed...");
        }
    }
}
