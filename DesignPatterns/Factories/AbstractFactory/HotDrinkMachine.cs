using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns.Factories.AbstractFactory
{
    public class HotDrinkMachine
    {
        public enum AvailableDrink // violates open-closed
        {
            Coffee, Tea
        }

        //private Dictionary<AvailableDrink, IHotDrinkFactory> factories =
        //  new Dictionary<AvailableDrink, IHotDrinkFactory>();

        private List<Tuple<string, IHotDrinkFactory>> namedFactories =
          new List<Tuple<string, IHotDrinkFactory>>(); //dependency injection in webapi

        public HotDrinkMachine()
        {
            //foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
            //{
            //  var factory = (IHotDrinkFactory) Activator.CreateInstance(
            //    Type.GetType("DotNetDesignPatternDemos.Creational.AbstractFactory." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory"));
            //  factories.Add(drink, factory);
            //}

            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    namedFactories.Add(Tuple.Create(
                      t.Name.Replace("Factory", string.Empty), (IHotDrinkFactory)Activator.CreateInstance(t)!));
                }
            }
        }
        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks");
            for (var index = 0; index < namedFactories.Count; index++)
            {
                var tuple = namedFactories[index];
                Console.WriteLine($"{index}: {tuple.Item1}");
            }

            while (true)
            {
                string? s;
                if ((s = ReadLine()) != null
                    && int.TryParse(s, out int i) // c# 7
                    && i >= 0
                    && i < namedFactories.Count)
                {
                    Console.Write("Specify amount: ");
                    s = ReadLine();
                    if (s != null
                        && int.TryParse(s, out int amount)
                        && amount > 0)
                    {
                        return namedFactories[i].Item2.Prepare(amount);
                    }
                }
                Console.WriteLine("Incorrect input, try again.");
            }
        }

        //public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        //{
        //  return factories[drink].Prepare(amount);
        //}
    }
}
