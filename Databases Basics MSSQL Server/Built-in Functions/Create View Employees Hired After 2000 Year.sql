create view V_EmployeesHiredAfter2000 as
select FirstName, LastName from Employees
where datepart(year, HireDate) > '2000'
go

select * from V_EmployeesHiredAfter2000
go