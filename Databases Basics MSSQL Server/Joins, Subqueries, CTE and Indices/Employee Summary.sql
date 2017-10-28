select e1.EmployeeID, 
e1.FirstName + ' ' + e1.LastName as EmployeeName, 
e2.FirstName + ' ' + e2.LastName as ManagerName,
d.Name as DepartmentName
from Employees as e1
inner join Employees as e2
on e1.ManagerID = e2.EmployeeID
inner join Departments as d
on e1.DepartmentID = d.DepartmentID
order by e1.EmployeeID