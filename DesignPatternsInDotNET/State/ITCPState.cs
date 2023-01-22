using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal interface ITCPState
    {
        public void HandleConnection(TCPPort context);
    }
}
