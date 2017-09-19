using System;

namespace Employee_Data
{
    public class Startup
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var employeeId = int.Parse(Console.ReadLine());
            var monthlySalary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employeeId:d8}");
            Console.WriteLine($"Salary: {monthlySalary:f2}");
        }
    }
}
