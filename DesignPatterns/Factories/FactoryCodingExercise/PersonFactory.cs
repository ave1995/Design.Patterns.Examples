using System;
using System.Collections.Generic;

namespace DesignPatterns.Factories.FactoryCodingExercise
{
    public class PersonFactory
    {
        private readonly IList<WeakReference<Person>> _persons = new List<WeakReference<Person>>();

        public Person CreatePerson(string name)
        {
            var person = new Person
            {
                Name = name,
                Id = _persons.Count
            };

            _persons.Add(new WeakReference<Person>(person));
            return person;
        }
    }
}
