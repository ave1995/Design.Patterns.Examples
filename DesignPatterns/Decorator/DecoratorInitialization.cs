using DesignPatterns.Decorator.CycleDetection;
using DesignPatterns.Decorator.MultipleInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class DecoratorInitialization
    {
        public static void MultipleInheritanceInit()
        {
            var dragon = new Dragon { Age = 5 };

            if (dragon is IBird bird)
                bird.Fly();

            if (dragon is ILizard lizard)
                lizard.Crawl();
        }

        public static void CycleDetectionInit()
        {
            var circle = new Circle(2);
            var colored1 = new ColoredShape(circle, "red");
            var colored2 = new ColoredShape(colored1, "blue");

            Console.WriteLine(circle.AsString());
            Console.WriteLine(colored1.AsString());
            Console.WriteLine(colored2.AsString());
        }

        public static void DecoratorExerciseInit()
        {
            var t = new DecoratorExercise.DecoratorCodingExercise.Dragon(5);
            t.Fly();
        }
    }
}
