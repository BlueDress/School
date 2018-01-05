using AutoMapper;
using Employees.Dto;
using Employees.Models;

namespace Employees.App
{
    public class EmployeesProfile : Profile
    {
        public EmployeesProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
            CreateMap<Employee, EmployeePersonalDto>();
            CreateMap<EmployeePersonalDto, Employee>();
        }
    }
}
