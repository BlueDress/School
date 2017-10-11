create view V_EmployeesSalaries as
select FirstName, LastName, Salary from Employees
go

select * from V_EmployeesSalaries
go