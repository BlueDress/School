select u.Username, 
g.Name as Game,
count(i.Id) as 'Items Count',
sum(i.Price) as 'Items Price'
from Users as u
inner join UsersGames as ug
on u.Id = ug.UserId
inner join UserGameItems as ugi
on ug.Id = ugi.UserGameId
inner join Items as i
on ugi.ItemId = i.Id
inner join Games as g
on ug.GameId = g.Id
group by u.Username, g.Name
having count(i.Id) >= 10
order by 'Items Count' desc, 'Items Price' desc, u.Username