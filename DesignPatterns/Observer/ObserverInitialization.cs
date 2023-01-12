using DesignPatterns.Observer.ObserverViaEventKeyword;
using DesignPatterns.Observer.ObserverViaInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class ObserverInitialization
    {
        private static void CallDoctor(object sender, FallsIllEventArgs eventArgs)
        {
            Console.WriteLine($"A doctor has been called to {eventArgs.Address}");
        }
      
        public static void ObserverViaEventKeywordInit()
        {
            var person = new Person();

            person.FallsIll += CallDoctor;

            person.CatchACold();
        }

        public static void ObserverViaInterfacesInit()
        {
            var employee = new Employee();
            var subscriber = new EventObserver();
            var sub = employee.Subscribe(subscriber);

            employee.CatchACold();

            sub.Dispose();

            employee.CatchACold(); //no console

        }
    }
}
