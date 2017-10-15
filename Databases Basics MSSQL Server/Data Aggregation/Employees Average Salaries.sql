select * into NewEmployeesTable from Employees
where Salary > 30000
go

delete from NewEmployeesTable
where ManagerId = 42
go

update NewEmployeesTable
set Salary += 5000
where DepartmentID = 1
go

select DepartmentID, avg(Salary) as AverageSalary from NewEmployeesTable
group by DepartmentID
go