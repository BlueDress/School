delete from Locations
where Id in 
(select l.Id from Locations as l
left join Users as u
on l.Id = u.LocationId
where u.Id is null)