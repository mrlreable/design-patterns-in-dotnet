﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class TCPOpen : ITCPState
    {
        public void HandleConnection(TCPPort context)
        {
            Console.WriteLine($"Connected to port {context.PortNumber}");
        }
    }
}
