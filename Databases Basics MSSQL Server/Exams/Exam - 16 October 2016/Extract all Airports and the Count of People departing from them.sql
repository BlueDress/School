select a.AirportID, a.AirportName, gr.Passengers from (select a.AirportID, count(*) as Passengers 
from Tickets as t
inner join Flights as f
on t.FlightID = f.FlightID
inner join Airports as a
on f.OriginAirportID = a.AirportID
where Status = 'Departing'
group by AirportID) as gr
inner join Airports as a
on gr.AirportID = a.AirportID
order by AirportID