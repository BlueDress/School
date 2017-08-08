using System;
using System.Collections.Generic;
using System.Reflection;

namespace Oldest_Family_Member
{
    public class OldestFamilyMember
    {
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var numberOfPeople = int.Parse(Console.ReadLine());
            var family = new Family()
            {
                People = new List<Person>(),
            };

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

                family.AddMember(person);
            }

            var oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
