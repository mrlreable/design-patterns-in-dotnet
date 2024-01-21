namespace Visitor
{
    public interface IVisitor
    {
        public void ExportForCity(City city);
        public void ExportForIndustry(Industry industry);
    }
}
