using System;
using System.Collections.Generic;

namespace Equality_Logic
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var sortedPeople = new SortedSet<Person>();
            var hashedPeople = new HashSet<Person>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                var person = new Person(name, age);
                sortedPeople.Add(person);
                hashedPeople.Add(person);
            }

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(hashedPeople.Count);
        }
    }
}
