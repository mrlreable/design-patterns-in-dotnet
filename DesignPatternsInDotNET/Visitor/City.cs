namespace Visitor
{
    public class City : INode
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Population { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.ExportForCity(this);
        }
    }
}
