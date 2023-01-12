using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns.Observer.ObserverViaInterfaces
{
    internal class EventObserver : IObserver<Event>
    {
        public EventObserver()
        {
            //var employee = new Employee();
            //var sub = employee.Subscribe(this);

            //employee.OfType<FallsIllEvent>()
            //  .Subscribe(args => WriteLine($"A doctor has been called to {args.Address}"));
        }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(Event value)
        {
            if (value is FallsIllEvent args)
                WriteLine($"A doctor has been called to {args.Address}");
        }
    }
}
