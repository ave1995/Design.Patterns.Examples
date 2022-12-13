using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.DecoratorExercise
{
    public class DecoratorCodingExercise
    {
        public class Bird
        {
            public int Age { get; set; }

            public string Fly()
            {
                return (Age < 10) ? "flying" : "too old";
            }
        }

        public class Lizard
        {
            public int Age { get; set; }

            public string Crawl()
            {
                return (Age > 1) ? "crawling" : "too young";
            }
        }

        public class Dragon // no need for interfaces
        {
            private Bird bird = new Bird();
            private Lizard lizard = new Lizard();

            public Dragon(int a)
            {
                this.Age = a;
            }

            private int age;

            public int Age {
                get => age;
                set { age = value; bird.Age = value; lizard.Age = value; }
            }

            public string Fly()
            {
                return bird.Fly();
            }

            public string Crawl()
            {
                return lizard.Crawl();
            }
        }
    }
}
