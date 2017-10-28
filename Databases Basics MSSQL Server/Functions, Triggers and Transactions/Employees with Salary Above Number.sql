create proc usp_GetEmployeesSalaryAboveNumber(@number money) as
select FirstName, LastName from Employees
where Salary >= @number
go

exec usp_GetEmployeesSalaryAboveNumber 48100
go