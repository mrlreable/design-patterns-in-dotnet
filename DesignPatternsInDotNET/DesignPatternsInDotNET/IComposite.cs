using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Provides common interface for Products and boxes (composite)
    internal interface IComposite
    {
        public double CalculatePrice();
    }
}
