using System;
using System.Collections.Generic;
using System.Linq;

namespace Group_by_Group
{
    public class GroupByGroup
    {
        public static void Main()
        {
            var students = new List<Student>();

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
                    var name = tokens[0] + " " + tokens[1];
                    var group = int.Parse(tokens[2]);

                    var student = new Student
                    {
                        Name = name,
                        Group = group,
                    };

                    students.Add(student);
                }
            }
            var groupedStudents = students.GroupBy(x => x.Group).ToDictionary(x => x.Key);

            foreach (var group in groupedStudents.OrderBy(x => x.Key))
            {
                var names = new List<string>();

                foreach (var student in group.Value)
                {
                    names.Add(student.Name);
                }

                Console.WriteLine($"{group.Key} - {string.Join(", ", names)}");
            }
        }
    }
}
