using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_by_First_and_Last_Name
{
    public class StudentsByFirstAndLastName
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
            }).Where(x => x.firstName[0] < x.secondName[0]).ToList().ForEach(x => Console.WriteLine($"{x.firstName} {x.secondName}"));
        }
    }
}
