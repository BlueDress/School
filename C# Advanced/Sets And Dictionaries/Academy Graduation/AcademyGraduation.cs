using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy_Graduation
{
    public class AcademyGraduation
    {
        public static void Main()
        {
            var studentsGraduatingScores = new SortedDictionary<string, List<double>>();

            var numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                var name = Console.ReadLine();
                var grades = Console.ReadLine().Split().Select(double.Parse).ToList();

                if (!studentsGraduatingScores.ContainsKey(name))
                {
                    studentsGraduatingScores[name] = new List<double>();
                }

                studentsGraduatingScores[name] = grades;
            }

            foreach (var student in studentsGraduatingScores)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }
        }
    }
}
