using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Roster
{
    public class CompanyRoster
    {
        public static void Main()
        {
            var numberOfEmployees = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            ProcessTheInput(numberOfEmployees, employees);
            var highestPaidDepartment = FindHighestPaidDepartment(employees);
            PrintResult(employees, highestPaidDepartment);
        }

        private static string FindHighestPaidDepartment(List<Employee> employees)
        {
            var groupedEmployees = employees.GroupBy(x => x.Department).ToList();
            var highestAverageSalary = -1.0;
            var highestPaidDepartment = string.Empty;

            foreach (var group in groupedEmployees)
            {
                var averageSalary = group.Average(x => x.Salary);
                if (highestAverageSalary < averageSalary)
                {
                    highestAverageSalary = averageSalary;
                    highestPaidDepartment = group.Key;
                }
            }

            return highestPaidDepartment;
        }

        private static void PrintResult(List<Employee> employees, string highestPaidDepartment)
        {
            Console.WriteLine($"Highest Average Salary: {highestPaidDepartment}");

            foreach (var employee in employees.Where(employee => employee.Department.Equals(highestPaidDepartment)).OrderByDescending(employee => employee.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }

        private static void ProcessTheInput(int numberOfEmployees, List<Employee> employees)
        {
            for (int i = 0; i < numberOfEmployees; i++)
            {
                var tokens = Console.ReadLine().Split();
                var name = tokens[0];
                var salary = double.Parse(tokens[1]);
                var position = tokens[2];
                var department = tokens[3];

                if (tokens.Length == 6)
                {
                    var email = tokens[4];
                    var age = int.Parse(tokens[5]);
                    var employee = new Employee(name, salary, position, department, email, age);
                    employees.Add(employee);
                }
                else if (tokens.Length == 4)
                {
                    var employee = new Employee(name, salary, position, department);
                    employees.Add(employee);
                }
                else
                {
                    var email = tokens[4];
                    var age = -1;

                    if (int.TryParse(tokens[4], out age))
                    {
                        var employee = new Employee(name, salary, position, department, age);
                        employees.Add(employee);
                    }
                    else
                    {
                        var employee = new Employee(name, salary, position, department, email);
                        employees.Add(employee);
                    }
                }
            }
        }
    }
}
