using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Customer : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine(message);
        }
    }
}
