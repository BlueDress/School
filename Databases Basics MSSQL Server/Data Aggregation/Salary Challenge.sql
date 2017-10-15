select top(10) FirstName, LastName, DepartmentID from Employees as allEmp
where Salary > (
select avg(Salary) as AverageSalary from Employees as avgEmp
where allEmp.DepartmentID = avgEmp.DepartmentID
group by DepartmentID
)
order by DepartmentID
