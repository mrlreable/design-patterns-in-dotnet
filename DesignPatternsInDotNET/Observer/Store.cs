using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Store : ISubject
    {
        private double _productPrice;
        public List<IObserver> Observers { get; }

        public Store()
        {
            Observers = new List<IObserver>();
        }

        public double ProductPrice
        {
            get { return _productPrice; }
            set
            {
                _productPrice = value;
                NotifyObservers();
            }
        }

        public void NotifyObservers()
        {
            foreach (var customer in Observers)
            {
                customer.Update($"The price of the product changed. New price: {_productPrice}");
            }
        }

        public void Subscribe(IObserver observer)
        {
            Observers.Add(observer);
            Console.WriteLine("Customer subscribed");
        }

        public void Unsubscribe(IObserver observer)
        {
            Observers.Remove(observer);
            Console.WriteLine("Customer unsubscribed");
        }
    }
}
