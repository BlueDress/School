insert into Messages
select concat(u.Age, '-', u.Gender, '-', l.Latitude, '-', l.Longitude),
getdate(),
case
when u.Gender = 'F' then ceiling(sqrt(u.Age * 2))
when u.Gender = 'M' then ceiling(power(u.age / 18, 3))
end,
u.Id
from Users as u
inner join Locations as l
on u.LocationId = l.Id
where u.Id between 10 and 20
go