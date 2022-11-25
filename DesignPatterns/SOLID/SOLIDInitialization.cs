using DesignPatterns.SOLID.OpenClosedPrinciple;
using DesignPatterns.SOLID.SingleResponsibilityPrinciple;
using System.Diagnostics;


namespace DesignPatterns.SOLID
{
    public class SOLIDInitialization
    {
        public static void SingleResponsibilityPrinciple()
        {
            var j = new Journal();
            j.AddEntry("I cried today.");
            j.AddEntry("I ate a bug.");
            Console.WriteLine(j);

            var filename = Path.GetTempPath() + @"journal.txt";
            Persistence.SaveToFile(j, filename);

            var process = new Process
            {
                StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = filename
                }
            };
            process.Start();
            process.WaitForExit();
        }

        public static void OpenClosedPrinciple()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var bf = new BetterFilterProduct();

            foreach (var product in bf.Filter(products, new ColorSpecification(Color.Green)))
                Console.WriteLine($" - {product.Name} is green");

            Console.WriteLine(Environment.NewLine);

            ISpecification<Product>[] specifications = { new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large) };

            foreach (var product in bf.Filter(products, new MultipleSpecifications<Product>(specifications)))
                Console.WriteLine($" - {product.Name} is blue and large");


        }
    }
}
