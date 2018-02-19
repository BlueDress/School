using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    public class Startup
    {
        public static void Main()
        {
            var doctorsPatients = new Dictionary<string, List<string>>();
            var departmentsPatients = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Output"))
                {
                    break;
                }

                var args = input.Split();

                var department = args[0];
                var doctor = $"{args[1]} {args[2]}";
                var patient = args[3];

                if (!departmentsPatients.ContainsKey(department))
                {
                    departmentsPatients[department] = new List<string>();
                }

                if (departmentsPatients[department].Count < 60)
                {
                    departmentsPatients[department].Add(patient);

                    if (!doctorsPatients.ContainsKey(doctor))
                    {
                        doctorsPatients[doctor] = new List<string>();
                    }

                    doctorsPatients[doctor].Add(patient);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }

                var commands = input.Split();

                if (commands.Length == 1)
                {
                    var department = commands[0];

                    foreach (var patient in departmentsPatients[department])
                    {
                        Console.WriteLine(patient);
                    }
                }
                else
                {
                    if (int.TryParse(commands[1], out int roomNumber))
                    {
                        var department = commands[0];

                        var patientsToPrint = new SortedSet<string>
                        {
                            departmentsPatients[department][(roomNumber - 1) * 3],
                            departmentsPatients[department][(roomNumber - 1) * 3 + 1],
                            departmentsPatients[department][(roomNumber - 1) * 3 + 2]
                        };

                        foreach (var patient in patientsToPrint)
                        {
                            Console.WriteLine(patient);
                        }
                    }
                    else
                    {
                        var doctor = $"{commands[0]} {commands[1]}";

                        foreach (var patient in doctorsPatients[doctor].OrderBy(p => p))
                        {
                            Console.WriteLine(patient);
                        }
                    }
                }
            }
        }
    }
}
