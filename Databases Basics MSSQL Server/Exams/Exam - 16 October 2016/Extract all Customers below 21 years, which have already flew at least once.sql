select c.CustomerID, c.FirstName + ' ' + c.LastName as FullName, datediff(year, c.DateOfBirth, getdate()) as Age from Customers as c
inner join Tickets as t
on c.CustomerID = t.CustomerID
inner join Flights as f
on t.FlightID = f.FlightID
where datediff(year, c.DateOfBirth, getdate()) < 21 and f.Status = 'Arrived'
order by Age desc, CustomerID