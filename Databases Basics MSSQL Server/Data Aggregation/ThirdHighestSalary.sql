select DepartmentID, Salary as ThirdHighestSalary from 
(select 
DepartmentID, 
max(Salary) as Salary, 
dense_rank() over(partition by DepartmentID order by Salary desc) as Rank 
from Employees
group by DepartmentID, Salary) as TempTable
where Rank = 3