update Tickets
set Price += Price * 0.5
where FlightID in 
(select top 1 with ties t.FlightID from Airlines as a
inner join Flights as f
on a.AirlineID = f.AirlineID
inner join Tickets as t
on f.FlightID = t.FlightID
order by a.Rating desc)
go