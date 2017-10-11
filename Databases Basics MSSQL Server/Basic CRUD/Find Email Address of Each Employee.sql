create view V_FullEmail as
select FirstName + '.' + LastName + '@softuni.bg' as 'Full Email Addres'
from Employees 
go

select * from V_FullEmail
go