using DesignPatterns.Factories.AbstractFactory;
using DesignPatterns.Factories.BulkReplacement;
using DesignPatterns.Factories.FactoryMethod;

namespace DesignPatterns.Factories
{
    public class FactoriesInitialization
    {
        public static void BulkReplacementInit()
        {
            var factory = new TrackingThemeFactory();
            var theme = factory.CreateTheme(true);
            var theme2 = factory.CreateTheme(false);
            Console.WriteLine(factory.Info);
            // Dark theme
            // Light theme


            // replacement
            var factory2 = new ReplaceableThemeFactory();
            var magicTheme = factory2.CreateTheme(true);
            Console.WriteLine(magicTheme.Value.BgrColor); // dark gray
            factory2.ReplaceTheme(false);
            Console.WriteLine(magicTheme.Value.BgrColor); // white
        }

        public static void FactoryMethodInit()
        {
            var p1 = new Point(2, 3, CoordinateSystem.Cartesian);
            var origin = Point.Origin2;

            var p2 = Point.Factory.NewCartesianPoint(1, 2);

            Console.WriteLine(p2);
        }

        public static void AbstractFactoryInit()
        {
            var machine = new HotDrinkMachine();
            //var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 300);
            //drink.Consume();

            IHotDrink drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}
