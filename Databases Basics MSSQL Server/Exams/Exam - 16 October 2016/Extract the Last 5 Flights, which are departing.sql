select top 5 f.FlightID, f.DepartureTime, f.ArrivalTime, ao.AirportName as Origin, ad.AirportName as Destination from Flights as f
inner join Airports as ao
on f.OriginAirportID = ao.AirportID
inner join Airports as ad
on f.DestinationAirportID = ad.AirportID
where Status = 'Departing'
order by DepartureTime, FlightID