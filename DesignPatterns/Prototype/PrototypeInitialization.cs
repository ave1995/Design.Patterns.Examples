using DesignPatterns.Prototype.Inheritance;
using DesignPatterns.Prototype.PrototypeCodingExercise;
using DesignPatterns.Prototype.Serialization;
using static System.Console;

namespace DesignPatterns.Prototype
{
    public class PrototypeInitialization
    {
        public static void InheritanceInit()
        {
            var john = new Employee();
            john.Names = new[] { "John", "Doe" };
            john.Address = new Address { HouseNumber = 123, StreetName = "London Road" };
            john.Salary = 321000;
            var copy = john.DeepCopy();

            copy.Names[1] = "Smith";
            copy.Address.HouseNumber++;
            copy.Salary = 123000;

            WriteLine(john);
            WriteLine(copy);
        }

        public static void SerializationInit()
        {
            Foo foo = new Foo { Stuff = 42, Whatever = "abc" };

            Foo foo2 = foo.DeepCopyBinary(); // crashes without [Serializable]
            Foo foo3 = foo.DeepCopyXml();

            foo2.Whatever = "xyz";
            foo3.Whatever = "ghj";
            WriteLine(foo);
            WriteLine(foo2);
            WriteLine(foo3);
        }
    }
}
