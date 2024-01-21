using System.Xml;
using System.Xml.Serialization;

namespace Visitor
{
    public class ExportToXmlVisitor : IVisitor
    {
        private XmlSerializer _serializer;

        public void ExportForCity(City city)
        {
            _serializer = new XmlSerializer(typeof(City));

            using (var writer = new StringWriter())
            {
                _serializer.Serialize(writer, city);
                Console.WriteLine(writer.ToString());
            }

            Console.WriteLine("XML export finished for city!");
        }

        public void ExportForIndustry(Industry industry)
        {
            _serializer = new XmlSerializer(typeof(Industry));

            using (var writer = new StringWriter())
            {
                _serializer.Serialize(writer, industry);
                Console.WriteLine(writer.ToString());
            }

            Console.WriteLine("XML export finished for industry!");
        }
    }
}
