select g.Name as Game,
gt.Name as 'Game Type',
u.Username,
ug.Level,
ug.Cash,
c.Name as Character
from Games as g
inner join GameTypes as gt
on g.GameTypeId = gt.Id
inner join UsersGames as ug
on g.Id = ug.GameId
inner join Characters as c
on ug.CharacterId = c.Id
inner join Users as u
on ug.UserId = u.Id
order by ug.Level desc, u.Username, g.Name