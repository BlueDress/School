using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Students
{
    public class SortStudents
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

                return new { firstName, secondName };
            }).OrderBy(x => x.secondName).ThenByDescending(x => x.firstName).ToList().ForEach(x => Console.WriteLine($"{x.firstName} {x.secondName}"));
        }
    }
}
