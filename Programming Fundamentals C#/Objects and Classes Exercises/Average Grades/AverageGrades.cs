using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Grades
{
    public class AverageGrades
    {
        public static void Main()
        {
            var numberOfStudents = int.Parse(Console.ReadLine());

            var excellentStudents = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var inputCommands = Console.ReadLine().Split().ToList();
                var student = new Student();
                student.Name = inputCommands[0];
                var grades = inputCommands.Skip(1).Select(double.Parse).ToList();

                student.Grades = grades;

                if (student.AverageGrade >= 5.00)
                {
                    excellentStudents.Add(student);
                }
            }
            foreach (var student in excellentStudents.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
}
