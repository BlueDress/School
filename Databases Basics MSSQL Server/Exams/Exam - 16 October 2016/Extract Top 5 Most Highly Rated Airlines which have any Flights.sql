select a.AirlineID, a.AirlineName, a.Nationality, a.Rating from (select a.Rating from Airlines as a
inner join Flights as f
on a.AirlineID = f.AirlineID
group by a.Rating) as gr
inner join Airlines as a
on gr.Rating = a.Rating
order by Rating desc, AirlineID