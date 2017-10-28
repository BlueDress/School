using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Mentor_group
{
    public class MentorGroup
    {
        public static void Main()
        {
            var report = new List<Student>();

            while (true)
            {
                var inputCommands = Console.ReadLine().Split(' ', ',').ToList();

                if (inputCommands[0] == "end" && inputCommands[1] == "of" && inputCommands[2] == "dates")
                {
                    break;
                }
                else
                {
                    var name = inputCommands[0];

                    if (!report.Any(x => x.Name == name))
                    {
                        var newStudent = new Student();
                        newStudent.Name = inputCommands[0];

                        var dates = new List<DateTime>();

                        if (inputCommands.Count > 1)
                        {
                            for (int i = 1; i < inputCommands.Count; i++)
                            {
                                dates.Add(DateTime.ParseExact(inputCommands[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                            }
                        }
                        newStudent.Dates = dates;

                        var comments = new List<string>();
                        newStudent.Comments = comments;
                        report.Add(newStudent);
                    }
                    else
                    {
                        var addDate = report.First(x => x.Name == name);

                        if (inputCommands.Count > 1)
                        {

                            for (int i = 1; i < inputCommands.Count; i++)
                            {
                                addDate.Dates.Add(DateTime.ParseExact(inputCommands[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                            }
                        }
                    }
                }
            }

            while (true)
            {
                var inputCommands = Console.ReadLine().Split('-').ToList();

                if (inputCommands[0] == "end of comments")
                {
                    break;
                }
                else
                {
                    if (report.Any(x => x.Name == inputCommands[0]))
                    {
                        var addComment = report.First(x => x.Name == inputCommands[0]);

                        for (int i = 1; i < inputCommands.Count; i++)
                        {
                            addComment.Comments.Add(inputCommands[i]);
                        }
                    }
                }
            }

            foreach (var student in report.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{student.Name}");

                Console.WriteLine("Comments:");

                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in student.Dates.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
}
