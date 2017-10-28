select top 3 c.CustomerID, c.FirstName + ' ' + c.LastName as FullName, t.Price as TicketPrice, a.AirportName as Destination from Customers as c
inner join Tickets as t
on c.CustomerID = t.CustomerID
inner join Flights as f
on t.FlightID = f.FlightID
inner join Airports as a
on f.DestinationAirportID = a.AirportID
where f.Status = 'Delayed'
order by TicketPrice desc, c.CustomerID