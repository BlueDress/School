select c.CustomerID, c.FirstName + ' ' + c.LastName as FullName, datediff(year, c.DateOfBirth, getdate()) as Age from Tickets as t
inner join Customers as c
on t.CustomerID = c.CustomerID
inner join Flights as f
on t.FlightID = f.FlightID
where f.Status = 'Departing'
order by Age, CustomerID