using System;
using System.Collections.Generic;
using System.Linq;

namespace Work_Force
{
    public class Startup
    {
        public static void Main()
        {
            var workers = new List<Employee>();
            var jobs = new List<Job>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }

                var commandArgs = input.Split();
                var command = commandArgs[0];

                switch (command)
                {
                    case "Job":
                        var jobName = commandArgs[1];
                        var jobHoursRequired = int.Parse(commandArgs[2]);
                        var wantedEmployeeName = commandArgs[3];

                        var wantedEmployee = workers.Find(em => em.Name.Equals(wantedEmployeeName));
                        var job = new Job(jobName, jobHoursRequired, wantedEmployee);
                        workers.Remove(wantedEmployee);
                        jobs.Add(job);
                        break;
                    case "StandartEmployee":
                        var standartEmployeeName = commandArgs[1];

                        var standartEmployee = new StandartEmployee(standartEmployeeName);

                        workers.Add(standartEmployee);
                        break;
                    case "PartTimeEmployee":
                        var PartTimeEmployeeName = commandArgs[1];

                        var partTimeEmployee = new PartTimeEmployee(PartTimeEmployeeName);

                        workers.Add(partTimeEmployee);
                        break;
                    case "Pass":
                        jobs.ForEach(j => j.Update());
                        jobs = jobs.Where(j => !j.IsDone).ToList();
                        break;
                    case "Status":
                        jobs.ForEach(j => Console.WriteLine(j));
                        break;
                }
            }
        }
    }
}
