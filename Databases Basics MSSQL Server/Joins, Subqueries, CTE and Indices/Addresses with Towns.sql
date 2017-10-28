select top 50 e.FirstName, e.LastName,t.Name, a.AddressText from Employees as e
inner join Addresses as a
on e.AddressID = a.AddressID
inner join Towns as t
on a.TownID = t.TownID
order by e.FirstName, e.LastName