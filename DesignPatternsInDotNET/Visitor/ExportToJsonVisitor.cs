using System.Text.Json;

namespace Visitor
{
    // In this example the type of the node does not matter
    // We could define one Export method that accepts an INode
    // But we can see the export method for different nodes may not be the same
    public class ExportToJsonVisitor : IVisitor
    {
        private JsonSerializerOptions _options = new JsonSerializerOptions { WriteIndented = true };

        public void ExportForCity(City city)
        {
            string jsonString = JsonSerializer.Serialize(city, _options);
            Console.WriteLine(jsonString);
            Console.WriteLine("JSON export successfully finished for city!");
        }

        public void ExportForIndustry(Industry industry)
        {
            string jsonString = JsonSerializer.Serialize(industry, _options);
            Console.WriteLine(jsonString);
            Console.WriteLine("JSON export successfully finished for industry!");
        }
    }
}
