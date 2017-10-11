update Employees
set Salary = Salary * 1.12
where DepartmentID in (1, 2, 4, 11)
go

select Salary from Employees
go
 