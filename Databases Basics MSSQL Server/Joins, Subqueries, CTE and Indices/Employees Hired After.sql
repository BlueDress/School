select e.FirstName, e.LastName, e.HireDate, d.Name from Employees as e
inner join Departments as d
on e.DepartmentID = d.DepartmentID
where (d.Name = 'Sales' or d.name = 'Finance') and e.HireDate > '1999'
order by e.HireDate