using DesignPatterns.Observer.ObserverViaEventKeyword;
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
    }
}
