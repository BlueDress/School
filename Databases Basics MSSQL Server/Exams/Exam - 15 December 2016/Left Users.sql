select m.Id, m.ChatId, m.UserId from Messages as m
where m.ChatId = 17 and (m.UserId not in (select UserId from UsersChats where ChatId = 17) or m.UserId is null)
order by m.Id desc