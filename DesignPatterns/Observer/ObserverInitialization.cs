using DesignPatterns.Observer.BidirectionalObserver;
using DesignPatterns.Observer.ObservableCollections;
using DesignPatterns.Observer.ObserverPropertyDependencies;
using DesignPatterns.Observer.ObserverViaEventKeyword;
using DesignPatterns.Observer.ObserverViaInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public static void ObervableCollectionsInit()
        {
            Market market = new Market();
            //      market.PriceAdded += (sender, eventArgs) =>
            //      {
            //        Console.WriteLine($"Added price {eventArgs.Price}");
            //      };
            //      market.AddPrice(123);
            market.Prices.ListChanged += (sender, eventArgs) => // Subscribe
            {
                if (eventArgs.ListChangedType == ListChangedType.ItemAdded)
                {
                    Console.WriteLine($"Added price {((BindingList<float>)sender)[eventArgs.NewIndex]}");
                }
            };
            market.AddPrice(123);
            // 1) How do we know when a new item becomes available?

            // 2) how do we know when the market is done supplying items?
            // maybe you are trading a futures contract that expired and there will be no more prices

            // 3) What happens if the market feed is broken?
        }

        public static void BidirectionalObserverInit()
        {
            var product = new Product { Name = "Book" };
            var window = new Window(product);

            // want to ensure that when product name changes
            // in one component, it also changes in another

            // product.PropertyChanged += (sender, eventArgs) =>
            // {
            //   if (eventArgs.PropertyName == "Name")
            //   {
            //     Console.WriteLine("Name changed in Product");
            //     window.ProductName = product.Name;
            //   }
            // };
            //
            // window.PropertyChanged += (sender, eventArgs) =>
            // {
            //   if (eventArgs.PropertyName == "ProductName")
            //   {
            //     Console.WriteLine("Name changed in Window");
            //     product.Name = window.ProductName;
            //   }
            // };

            using var binding = new BidirectionalBinding(
              product,
              () => product.Name,
              window,
              () => window.ProductName);

            // there is no infinite loop because of
            // self-assignment guard
            product.Name = "Table";
            window.ProductName = "Chair";

            Console.WriteLine(product);
            Console.WriteLine(window);
        }

        public static void ObserverPropertyDependenciesInit()
        {
            var p = new Voter();
            p.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine($"{eventArgs.PropertyName} has changed");
            };
            p.Age = 15; // should not really affect CanVote :)
            p.Citizen = true;
        }

    }
}
