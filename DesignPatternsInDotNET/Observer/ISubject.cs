using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal interface ISubject
    {
        public List<IObserver> Observers { get; }

        public void Subscribe(IObserver observer);

        public void Unsubscribe(IObserver observer);

        public void NotifyObservers();
    }
}
