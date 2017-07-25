using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_by_Group
{
    public class StudentsByGroup
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
                    if (input.EndsWith("2"))
                    {
                        students.Add(input.Substring(0, input.Length - 2));
                    }
                }
            }

            students.Select(x =>
            {
                var tokens = x.Split();
                var firstName = tokens[0];
                var secondName = tokens[1];

                return new { firstName, secondName };
            }).OrderBy(x => x.firstName).ToList().ForEach(x => Console.WriteLine($"{x.firstName} {x.secondName}"));
        }
    }
}
