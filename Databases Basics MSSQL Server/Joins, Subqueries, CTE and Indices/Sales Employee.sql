select e.EmployeeID, e.FirstName, e.LastName, d.Name from Employees as e
inner join Departments as d
on e.DepartmentID = d.DepartmentID
where d.Name = 'Sales'
order by EmployeeID