using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.ProxyCodingExercise
{
    public class Person
    {
        public int Age { get; set; }

        public string Drink()
        {
            return "drinking";
        }

        public string Drive()
        {
            return "driving";
        }

        public string DrinkAndDrive()
        {
            return "driving while drunk";
        }
    }

    public class ResponsiblePerson
    {
        private readonly Person person;
        public ResponsiblePerson(Person person)
        {
            this.person = person;
        }

        public int Age { get { return person.Age; } set { person.Age = value; } }

        public string Drink()
        {
            if (person.Age >= 18)
                return person.Drink();
            else
            {
                return "too young";
            }
        }

        public string Drive()
        {
            if (person.Age >= 16)
                return person.Drive();
            else
            {
                return "too young";
            }
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }

    }
}
