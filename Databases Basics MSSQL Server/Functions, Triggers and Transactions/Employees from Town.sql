create proc usp_GetEmployeesFromTown (@townName varchar(max)) as
select e.FirstName, e.LastName from Employees as e
inner join Addresses as a
on e.AddressID = a.AddressID
inner join Towns as t
on a.TownID = t.TownID
where t.Name = @townName
go

exec usp_GetEmployeesFromTown 'Sofia'
go