using Employees.Services;
using System.Linq;

namespace Employees.App.Commands
{
    public class SetAddressCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public SetAddressCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public string Execute(string[] args)
        {
            var employeeId = int.Parse(args[0]);
            var address = string.Join(" ", args.Skip(1));


            employeeService.SetAddress(employeeId, address);

            return "Address successfully set";
        }
    }
}
