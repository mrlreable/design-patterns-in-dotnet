using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Visitor
{
    // In this example the type of the node does not matter
    // We could define one Export method that accepts an INode
    // But we can see the export method for different nodes may not be the same
    internal class ExportToJsonVisitor : IVisitor
    {
        public void ExportForCity(City city)
        {
            string jsonString = JsonSerializer.Serialize(city);
            Console.WriteLine("Export successfully finished for city!");
            Console.WriteLine(jsonString);
        }

        public void ExportForIndustry(Industry industry)
        {
            string jsonString = JsonSerializer.Serialize(industry);
            Console.WriteLine("Export successfully finished for industry!");
            Console.WriteLine(jsonString);
        }
    }
}
