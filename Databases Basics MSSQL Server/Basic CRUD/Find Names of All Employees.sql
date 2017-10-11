create view V_FullName as
select FirstName + ' ' + ISNULL(MiddleName,'') + ' ' + LastName as 'Full Name'
from Employees
where Salary in (25000, 14000, 12500, 23600)
go

select * from V_FullName
go