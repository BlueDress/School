select t.TicketID, a.AirportName as Destination, c.FirstName + ' ' + c.LastName as FullName from Tickets as t
inner join Customers as c
on t.CustomerID = c.CustomerID
inner join Flights as f
on t.FlightID = f.FlightID
inner join Airports as a
on f.DestinationAirportID = a.AirportID
where class = 'First' and Price < 5000