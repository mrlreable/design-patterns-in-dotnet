using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Box : IComposite
    {
        public List<IComposite> Children { get; }

        public Box()
        {
            Children= new List<IComposite>();
        }

        public double CalculatePrice()
        {
            double price = 0;

            Console.WriteLine("Calculating price for composite...");

            foreach (var child in Children)
            {
                price += child.CalculatePrice();
            }

            return price;
        }

        public void AddChild(IComposite child)
        {
            Children.Add(child);
            Console.WriteLine("Child addded");
        }

        public void RemoveChild(IComposite child)
        {
            Children.Remove(child);
            Console.WriteLine("Child removed");
        }
    }
}
