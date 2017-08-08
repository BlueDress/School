using System;
using System.Collections.Generic;
using System.Linq;

namespace Opinion_Poll
{
    public class OpinionPoll
    {
        public static void Main()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var tokens = Console.ReadLine().Split();
                var name = tokens[0];
                var age = int.Parse(tokens[1]);

                var person = new Person
                {
                    Name = name,
                    Age = age
                };

                people.Add(person);
            }

            foreach (var person in people.Where(x => x.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
