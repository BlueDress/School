using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_by_Age
{
    public class StudentsByAge
    {
        public static void Main()
        {
            var students = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }
                else
                {
                    students.Add(input);
                }
            }

            students.Select(x =>
            {
                var tokens = x.Split();
                var firstName = tokens[0];
                var secondName = tokens[1];
                var age = int.Parse(tokens[2]);

                return new { firstName, secondName, age };
            }).Where(x => 18 <= x.age && x.age <= 24).ToList().ForEach(x => Console.WriteLine($"{x.firstName} {x.secondName} {x.age}"));
        }
    }
}
