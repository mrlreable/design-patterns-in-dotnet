namespace Visitor
{
    internal interface INode
    {
        public void Accept(IVisitor visitor);
    }
}
