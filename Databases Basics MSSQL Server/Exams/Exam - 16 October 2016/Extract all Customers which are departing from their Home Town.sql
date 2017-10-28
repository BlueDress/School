select c.CustomerID, c.FirstName + ' ' + c.LastName as FullName, t.TownName from Customers as c
inner join Towns as t
on c.HomeTownID = t.TownID
inner join Tickets as tic
on c.CustomerID = tic.CustomerID
inner join Flights as f
on tic.FlightID = f.FlightID
inner join Airports as a
on f.OriginAirportID = a.AirportID
where c.HomeTownID = a.TownID and f.Status = 'Departing'
order by c.CustomerID