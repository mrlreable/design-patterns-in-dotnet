using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Receipt : IComposite
    {
        public double CalculateCost()
        {
            Console.WriteLine("Receipt added");
            return 0;
        }
    }
}
