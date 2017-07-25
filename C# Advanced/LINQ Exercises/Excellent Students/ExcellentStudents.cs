using System;
using System.Collections.Generic;
using System.Linq;

namespace Excellent_Students
{
    public class ExcellentStudents
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
                var grades = new List<string>();

                for (int i = 2; i < tokens.Length; i++)
                {
                    grades.Add(tokens[i]);
                }

                return new { firstName, secondName, grades };
            }).Where(x => x.grades.Contains("6")).ToList().ForEach(x => Console.WriteLine($"{x.firstName} {x.secondName}"));
        }
    }
}
