create proc usp_EmployeesBySalaryLevel(@levelOfSalary varchar(7)) as
select FirstName, LastName from Employees as e
where dbo.ufn_GetSalaryLevel(Salary) = @levelOfSalary
go

exec usp_EmployeesBySalaryLevel 'High'
go