using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.Globalization;
using System.Linq;

namespace P02_DatabaseFirst
{
    public class Startup
    {
        public static void Main()
        {
            var db = new SoftUniAdvContext();

            EmployeesFullInformation(db);

            EmployeesWithSalaryOver50000(db);

            EmployeesFromResearchAndDevelopment(db);

            AddingNewAddressAndUpdatingEmployee(db);

            EmployeesAndProjects(db);

            AddressesByTown(db);

            Employee147(db);

            DepartmentsWithMoreThanFiveEmployees(db);

            FindLatestTenProjects(db);

            IncreaseSalaries(db);

            FindEmployeesFirstNameStartingWithSa(db);

            DeleteProjectById(db);

            RemoveTowns(db);
        }

        private static void RemoveTowns(SoftUniAdvContext db)
        {
            using (db)
            {
                var townToRemove = Console.ReadLine();

                db.Employees.Where(e => e.Address.Town.Name.Equals(townToRemove)).ToList().ForEach(e => e.AddressId = null);

                var addressesToRemove = db.Addresses.Where(a => a.Town.Name.Equals(townToRemove));

                db.Addresses.RemoveRange(addressesToRemove);

                db.Towns.Remove(db.Towns.First(t => t.Name.Equals(townToRemove)));

                if (addressesToRemove.Count() == 1)
                {
                    Console.WriteLine($"1 address in {townToRemove} was deleted");
                }
                else
                {
                    Console.WriteLine($"{addressesToRemove.Count()} addresses in {townToRemove} were deleted");
                }
            }
        }

        private static void DeleteProjectById(SoftUniAdvContext db)
        {
            using (db)
            {
                db.EmployeesProjects.RemoveRange(db.EmployeesProjects.Where(ep => ep.ProjectId == 2));

                db.Projects.Remove(db.Projects.First(p => p.ProjectId == 2));

                db.SaveChanges();

                db.Projects.Take(10).Select(p => p.Name).ToList().ForEach(n => Console.WriteLine(n));
            }
        }

        private static void FindEmployeesFirstNameStartingWithSa(SoftUniAdvContext db)
        {
            using (db)
            {
                db.Employees
                    .Where(e => e.FirstName.StartsWith("Sa"))
                    .Select(e => new
                    {
                        e.FirstName,
                        e.LastName,
                        e.JobTitle,
                        e.Salary
                    })
                    .OrderBy(e => e.FirstName).ThenBy(e => e.LastName)
                    .ToList()
                    .ForEach(e => Console.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})"));
            }
        }

        private static void IncreaseSalaries(SoftUniAdvContext db)
        {
            using (db)
            {
                db.Employees
                    .Where(e => e.Department.Name.Equals("Engineering") || e.Department.Name.Equals("Tool Design") || e.Department.Name.Equals("Marketing") || e.Department.Name.Equals("Information Services"))
                    .Select(e => new
                    {
                        e.FirstName,
                        e.LastName,
                        Salary = e.Salary + (e.Salary * 0.12m)
                    })
                    .OrderBy(e => e.FirstName).ThenBy(e => e.LastName)
                    .ToList()
                    .ForEach(e => Console.WriteLine($"{e.FirstName} {e.LastName} (${e.Salary:f2})"));
            }
        }

        private static void FindLatestTenProjects(SoftUniAdvContext db)
        {
            using (db)
            {
                db.Projects
                    .OrderByDescending(p => p.StartDate)
                    .Take(10)
                    .Select(p => new
                    {
                        p.Name,
                        p.Description,
                        StartDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                    })
                    .OrderBy(p => p.Name)
                    .ToList()
                    .ForEach((p) =>
                    {
                        Console.WriteLine(p.Name);
                        Console.WriteLine();
                        Console.WriteLine(p.Description);
                        Console.WriteLine();
                        Console.WriteLine(p.StartDate);
                    });
            }
        }

        private static void DepartmentsWithMoreThanFiveEmployees(SoftUniAdvContext db)
        {
            using (db)
            {
                db.Departments
                    .Where(d => d.Employees.Count > 5)
                    .OrderBy(d => d.Employees.Count).ThenBy(d => d.Name)
                    .Select(d => new
                    {
                        ManagerName = $"{d.Manager.FirstName} {d.Manager.LastName}",
                        d.Name,
                        Employees = d.Employees.Select(e => new
                        {
                            Name = $"{e.FirstName} {e.LastName}",
                            e.JobTitle
                        })
                    })
                    .ToList()
                    .ForEach((d) =>
                    {
                        Console.WriteLine($"{d.Name} – {d.ManagerName}");

                        foreach (var employee in d.Employees)
                        {
                            Console.WriteLine($"{employee.Name} - {employee.JobTitle}");
                        }

                        Console.WriteLine("----------");
                    });
            }
        }

        private static void Employee147(SoftUniAdvContext db)
        {
            using (db)
            {
                db.Employees
                    .Where(e => e.EmployeeId == 147)
                    .Select(e => new
                    {
                        Name = $"{e.FirstName} {e.LastName}",
                        e.JobTitle,
                        Projects = e.EmployeeProjects.Select(ep => ep.Project.Name).OrderBy(pn => pn)
                    })
                    .ToList()
                    .ForEach((e) =>
                    {
                        Console.WriteLine($"{e.Name} - {e.JobTitle}");

                        foreach (var project in e.Projects)
                        {
                            Console.WriteLine(project);
                        }
                    });
            }
        }

        private static void AddressesByTown(SoftUniAdvContext db)
        {
            using (db)
            {
                db.Addresses
                    .OrderByDescending(a => a.Employees.Count).ThenBy(a => a.Town.Name).ThenBy(a => a.AddressText)
                    .Take(10)
                    .Select(a => new
                    {
                        AddressText = a.AddressText,
                        TownName = a.Town.Name,
                        EmployeeCount = a.Employees.Count
                    })
                    .ToList()
                    .ForEach(a => Console.WriteLine($"{a.AddressText}, {a.TownName} - {a.EmployeeCount} employees"));
            }
        }

        private static void EmployeesAndProjects(SoftUniAdvContext db)
        {
            using (db)
            {
                db.Employees.Where(e => e.EmployeeProjects.Any(ep => ep.Project.StartDate.Year >= 2001 && ep.Project.StartDate.Year <= 2003))
                            .Take(30)
                            .Select(e => new
                            {
                                Name = $"{e.FirstName} {e.LastName}",
                                ManagerName = $"{e.Manager.FirstName} {e.Manager.LastName}",
                                Projects = e.EmployeeProjects.Select(ep => new
                                {
                                    ProjectName = ep.Project.Name,
                                    StartDate = ep.Project.StartDate,
                                    EndDate = ep.Project.EndDate
                                })
                            })
                            .ToList()
                            .ForEach((e) =>
                            {
                                Console.WriteLine($"{e.Name} – Manager: {e.ManagerName}");

                                var format = "M/d/yyyy h:mm:ss tt";

                                foreach (var project in e.Projects)
                                {
                                    if (project.EndDate == null)
                                    {
                                        Console.WriteLine($"--{project.ProjectName} - {project.StartDate.ToString(format, CultureInfo.InvariantCulture)} - not finished");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"--{project.ProjectName} - {project.StartDate.ToString(format, CultureInfo.InvariantCulture)} - {((DateTime)project.EndDate).ToString(format, CultureInfo.InvariantCulture)}");
                                    }
                                }
                            });
            }
        }

        private static void AddingNewAddressAndUpdatingEmployee(SoftUniAdvContext db)
        {
            using (db)
            {
                var address = new Address()
                {
                    AddressText = "Vitoshka 15",
                    TownId = 4
                };

                db.Addresses.Add(address);

                var employee = db.Employees.First(e => e.LastName.Equals("Nakov"));
                employee.Address = address;

                db.SaveChanges();

                db.Employees.OrderByDescending(e => e.AddressId).Take(10).Select(e => e.Address.AddressText).ToList().ForEach(a => Console.WriteLine(a));
            }
        }

        private static void EmployeesFromResearchAndDevelopment(SoftUniAdvContext db)
        {
            using (db)
            {
                db.Employees.Where(e => e.Department.Name.Equals("Research and Development"))
                    .OrderBy(e => e.Salary).ThenByDescending(e => e.FirstName)
                    .Select(e => new { e.FirstName, e.LastName, e.Department.Name, e.Salary})
                    .ToList().ForEach(e => Console.WriteLine($"{e.FirstName} {e.LastName} from {e.Name} - ${e.Salary:f2}"));
            }
        }

        private static void EmployeesWithSalaryOver50000(SoftUniAdvContext db)
        {
            using (db)
            {
                db.Employees.Where(e => e.Salary > 50000).OrderBy(e => e.FirstName).Select(e => e.FirstName).ToList().ForEach(e => Console.WriteLine(e));
            }
        }

        private static void EmployeesFullInformation(SoftUniAdvContext db)
        {
            using (db)
            {
                var employees = db.Employees;

                foreach (var employee in employees.OrderBy(e => e.EmployeeId))
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:f2}");
                }
            }
        }
    }
}
