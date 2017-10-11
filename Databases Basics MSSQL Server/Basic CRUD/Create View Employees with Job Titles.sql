create view V_EmployeeNameJobTitle as
select FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName as 'Full Name', JobTitle
from Employees
go

select * from V_EmployeeNameJobTitle
go