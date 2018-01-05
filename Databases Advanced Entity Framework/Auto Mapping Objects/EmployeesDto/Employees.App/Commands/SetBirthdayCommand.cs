using Employees.Services;
using System;
using System.Globalization;

namespace Employees.App.Commands
{
    public class SetBirthdayCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public SetBirthdayCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public string Execute(string[] args)
        {
            var employeeId = int.Parse(args[0]);
            var birthday = DateTime.ParseExact(args[1], "dd-MM-yyyy", CultureInfo.InvariantCulture);


            employeeService.SetBirthday(employeeId, birthday);

            return "Birthday successfully set";
        }
    }
}
