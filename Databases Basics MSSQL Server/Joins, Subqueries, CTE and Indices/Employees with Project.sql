select top 5 e.EmployeeID, e.FirstName, p.Name as ProjectName from Employees as e
right join EmployeesProjects as ep
on e.EmployeeID = ep.EmployeeID
inner join Projects as p
on ep.ProjectID = p.ProjectID
where p.StartDate > '2002-08-13'
order by e.EmployeeID