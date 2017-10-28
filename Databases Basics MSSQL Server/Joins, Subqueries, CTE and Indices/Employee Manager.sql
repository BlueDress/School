select e1.EmployeeID, e1.FirstName, e1.ManagerID, e2.FirstName from Employees as e1
inner join Employees as e2
on e1.ManagerID = e2.EmployeeID
where e1.ManagerID = 3 or e1.ManagerID = 7
order by e1.EmployeeID