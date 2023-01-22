using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal interface IVisitor
    {
        public void ExportForCity(City city);
        public void ExportForIndustry(Industry industry);
    }
}
