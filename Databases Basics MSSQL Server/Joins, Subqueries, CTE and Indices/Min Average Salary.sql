select min(AverageSalary) as MinAverageSalary from 
(select avg(e.Salary) as AverageSalary from Employees as e
inner join Departments as d
on e.DepartmentID = d.DepartmentID
group by e.DepartmentID) as avgSalary