select u.Nickname, c.Title, l.Latitude, l.Longitude from Users as u
inner join Locations as l
on u.LocationId = l.Id
inner join UsersChats as uc
on u.Id = uc.UserId
inner join Chats as c
on uc.ChatId = c.Id
where (Latitude between 41.14 and 44.13) and (Longitude between 22.21 and 28.36)
order by c.Title