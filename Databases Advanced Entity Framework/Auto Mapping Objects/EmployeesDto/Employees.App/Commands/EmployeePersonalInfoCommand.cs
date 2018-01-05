using Employees.Services;
using System.Text;

namespace Employees.App.Commands
{
    public class EmployeePersonalInfoCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public EmployeePersonalInfoCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public string Execute(string[] args)
        {
            var employeeId = int.Parse(args[0]);

            var employee = employeeService.GetEmployeePersonalInfoById(employeeId);

            var birthday = employee.Birthday == null ? "No birthday specified" : employee.Birthday.Value.ToString();

            var sb = new StringBuilder();

            sb.AppendLine($"ID: {employee.Id} - {employee.FirstName} {employee.LastName} - ${employee.Salary:f2}");

            sb.AppendLine($"Birthday: {birthday}");

            sb.AppendLine($"Address: {employee.Address ?? "No address available"}");

            return sb.ToString().Trim();
        }
    }
}
