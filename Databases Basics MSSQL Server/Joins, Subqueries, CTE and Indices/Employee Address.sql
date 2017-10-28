select top 5 e.EmployeeID, e.JobTitle, e.AddressID, a.AddressText from Employees as e
inner join Addresses as a
on e.AddressID = a.AddressID
order by a.AddressID