using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ch19P03
{
    public class Startup
    {
        public static void Main()
        {
            SortedDictionary<string, Dictionary<string, string>> specialityStudents = new SortedDictionary<string, Dictionary<string, string>>();

            using (StreamReader reader = new StreamReader("students.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    string[] args = line.Split("|").Select(x => x.Trim()).ToArray();
                    string[] names = args[0].Split();

                    string firstName = names[0];
                    string lastName = names[1];
                    string speciality = args[1];

                    if (!specialityStudents.ContainsKey(speciality))
                    {
                        specialityStudents[speciality] = new Dictionary<string, string>();
                    }

                    specialityStudents[speciality][firstName] = lastName;
                }
            }

            foreach (var speciality in specialityStudents)
            {
                Console.WriteLine($"{speciality.Key}: {string.Join(", ", speciality.Value.OrderBy(n => n.Value).ThenBy(n => n.Key).Select(n => $"{n.Key} {n.Value}"))}");
            }
        }
    }
}
