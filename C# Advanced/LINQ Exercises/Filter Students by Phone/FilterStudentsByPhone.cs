using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_Students_by_Phone
{
    public class FilterStudentsByPhone
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
                var phoneNumber = tokens[2];

                return new { firstName, secondName, phoneNumber };
            }).Where(x => x.phoneNumber.StartsWith("02") || x.phoneNumber.StartsWith("+3592")).ToList().ForEach(x => Console.WriteLine($"{x.firstName} {x.secondName}"));
        }
    }
}
