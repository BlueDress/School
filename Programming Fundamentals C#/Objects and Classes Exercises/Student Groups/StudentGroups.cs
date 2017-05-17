using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Student_Groups
{
    public class StudentGroups
    {
        public static void Main()
        {
            var towns = new List<Town>();
            var townName = string.Empty;

            while (true)
            {
                var inputString = Console.ReadLine();

                if (inputString.Equals("End"))
                {
                    break;
                }
                else
                {
                    if (inputString.EndsWith("seats"))
                    {
                        var newTown = new Town();
                        var inputCommands = inputString.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                        var seatsCountString = inputCommands[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var seatsCount = int.Parse(seatsCountString[0]);
                        townName = inputCommands[0].Trim();

                        newTown.Name = townName;
                        newTown.Seats = seatsCount;
                        newTown.Students = new List<Student>();

                        towns.Add(newTown);
                    }
                    else
                    {
                        var inputCommands = inputString.Split('|');
                        var studentName = inputCommands[0].Trim();
                        var studentEmail = inputCommands[1].Trim();
                        var registrationDate = DateTime.ParseExact(inputCommands[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                        var newStudent = new Student
                        {
                            Name = studentName,
                            Email = studentEmail,
                            RegistrationDate = registrationDate
                        };

                        var newTown = towns.First(x => x.Name == townName);
                        newTown.Students.Add(newStudent);
                        
                        if (newTown.Students.Count <= newTown.Seats)
                        {
                            newTown.Groups = 1;
                        }
                        else if (newTown.Students.Count > newTown.Seats && newTown.Students.Count % newTown.Seats == 0)
                        {
                            newTown.Groups = newTown.Students.Count / newTown.Seats;
                        }
                        else
                        {
                            newTown.Groups = newTown.Students.Count / newTown.Seats + 1;
                        }
                    }
                }
            }

            var groups = new List<Group>();

            foreach (var town in towns.OrderBy(x => x.Name))
            {
                IEnumerable<Student> students = town.Students.OrderBy(x => x.RegistrationDate).ThenBy(x => x.Name).ThenBy(x => x.Email);

                while (students.Any())
                {
                    var newGroup = new Group();

                    newGroup.Town = town;
                    newGroup.Students = students.Take(town.Seats).ToList();

                    students = students.Skip(town.Seats);

                    groups.Add(newGroup);
                }
            }

            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");

            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", group.Students.Select(x => x.Email))}");
            }
        }
    }
}
