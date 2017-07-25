using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_Enrolled_in_2014_or_2015
{
    public class StudentsEnrolledIn2014Or2015
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
                var facultyNumber = tokens[0];
                var grades = new List<string>();

                for (int i = 1; i < tokens.Length; i++)
                {
                    grades.Add(tokens[i]);
                }

                return new { facultyNumber, grades };
            }).Where(x => x.facultyNumber.EndsWith("14") || x.facultyNumber.EndsWith("15")).ToList().ForEach(x => Console.WriteLine(string.Join(" ", x.grades)));
        }
    }
}
