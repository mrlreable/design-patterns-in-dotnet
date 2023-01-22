using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Industry : INode
    {
        public string Name { get; set; }
        public string Sector { get; set; }
        public string LocatedAt { get; set; }
        public double NetWorth { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.ExportForIndustry(this);
        }
    }
}
