using System;
using System.Collections.Generic;

namespace Strategy_Pattern
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var peopleSortedByName = new SortedSet<Person>(new PersonNameComparer());
            var peopleSortedByAge = new SortedSet<Person>(new PersonAgeComparer());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var personData = Console.ReadLine().Split();
                var name = personData[0];
                var age = int.Parse(personData[1]);

                var person = new Person(name, age);
                peopleSortedByName.Add(person);
                peopleSortedByAge.Add(person);
            }

            foreach (var person in peopleSortedByName)
            {
                Console.WriteLine(person);
            }

            foreach (var person in peopleSortedByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}
