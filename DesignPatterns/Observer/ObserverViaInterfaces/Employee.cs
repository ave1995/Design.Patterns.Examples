using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.ObserverViaInterfaces
{
    public class Employee : IObservable<Event>
    {
        private readonly HashSet<Subscription> subscriptions
          = new HashSet<Subscription>();

        public IDisposable Subscribe(IObserver<Event> observer)
        {
            var subscription = new Subscription(this, observer);
            subscriptions.Add(subscription);
            return subscription;
        }

        public void CatchACold()
        {
            foreach (var sub in subscriptions)
                sub.Observer.OnNext(new FallsIllEvent { Address = "123 London Road" });
        }

        private class Subscription : IDisposable
        {
            private Employee employee;
            public IObserver<Event> Observer;

            public Subscription(Employee employee, IObserver<Event> observer)
            {
                this.employee = employee;
                Observer = observer;
            }

            public void Dispose()
            {
                employee.subscriptions.Remove(this);
            }
        }
    }
}
