alter table departments
alter column ManagerId int null
go

select e.EmployeeID from Employees as e
inner join Departments as d
on e.DepartmentID = d.DepartmentID
where d.Name in ('Production','Production Control')
go

delete from EmployeesProjects
where EmployeeID in (select e.EmployeeID from Employees as e
inner join Departments as d
on e.DepartmentID = d.DepartmentID
where d.Name in ('Production','Production Control'))
go

update Employees
set ManagerID = null
where ManagerID in (select e.EmployeeID from Employees as e
inner join Departments as d
on e.DepartmentID = d.DepartmentID
where d.Name in ('Production','Production Control'))
go

update Departments
set ManagerID = null
where ManagerID in (select e.EmployeeID from Employees as e
inner join Departments as d
on e.DepartmentID = d.DepartmentID
where d.Name in ('Production','Production Control'))
go

delete from Employees
where EmployeeID in (select e.EmployeeID from Employees as e
inner join Departments as d
on e.DepartmentID = d.DepartmentID
where d.Name in ('Production','Production Control'))
go

delete from Departments
where Name in ('Production','Production Control')
go