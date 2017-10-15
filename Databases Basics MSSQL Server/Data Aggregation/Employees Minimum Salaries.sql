select DepartmentID, min(Salary) as MinimumSalary from Employees
where DepartmentID in (2, 5,7) and HireDate > '2000-01-01'
group by DepartmentID