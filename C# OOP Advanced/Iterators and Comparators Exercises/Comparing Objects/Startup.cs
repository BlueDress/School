using System;
using System.Collections.Generic;

namespace Comparing_Objects
{
    public class Startup
    {
        public static void Main()
        {
            var people = new List<Person>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }

                var personData = input.Split();
                var name = personData[0];
                var age = int.Parse(personData[1]);
                var town = personData[2];

                var person = new Person(name, age, town);

                people.Add(person);
            }

            var personToCompare = people[int.Parse(Console.ReadLine()) - 1];
            var numberOfEqualPeople = 0;
            var numberOfNotEqualPeople = 0;

            foreach (var person in people)
            {
                if (personToCompare.CompareTo(person) == 0)
                {
                    numberOfEqualPeople++;
                }
                else
                {
                    numberOfNotEqualPeople++;
                }
            }

            if (numberOfEqualPeople == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{numberOfEqualPeople} {numberOfNotEqualPeople} {people.Count}");
            }
        }
    }
}
