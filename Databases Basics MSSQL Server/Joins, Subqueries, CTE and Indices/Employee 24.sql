select e.EmployeeID, e.FirstName, 
case 
when p.StartDate > '2005' then 'NULL'
else p.Name
end as ProjectName
from Employees as e
right join EmployeesProjects as ep
on e.EmployeeID = ep.EmployeeID
inner join Projects as p
on ep.ProjectID = p.ProjectID
where e.EmployeeID = 24

