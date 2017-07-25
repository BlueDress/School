using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_Joined_to_Specialties
{
    public class StudentsJoinedToSpecialties
    {
        public static void Main()
        {
            var specialties = new List<StudentSpecialty>();
            var students = new List<Student>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Students:"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split();
                    var name = tokens[0] + " " + tokens[1];
                    var facultyNumber = tokens[2];

                    var specialty = new StudentSpecialty
                    {
                        SpecialtyName = name,
                        FacultyNumber = facultyNumber
                    };

                    specialties.Add(specialty);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split();
                    var name = tokens[1] + " " + tokens[2];
                    var facultyNumber = tokens[0];

                    var student = new Student
                    {
                        StudentName = name,
                        FacultyNumber = facultyNumber
                    };

                    students.Add(student);
                }
            }

            var joined = students.Join(specialties, x => x.FacultyNumber, y => y.FacultyNumber, (x, y) => new { x.StudentName, x.FacultyNumber, y.SpecialtyName });

            foreach (var student in joined.OrderBy(x => x.StudentName))
            {
                Console.WriteLine($"{student.StudentName} {student.FacultyNumber} {student.SpecialtyName}");
            }
        }
    }
}
