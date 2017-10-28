select c.Id, Title, m.Id from Chats as c
inner join Messages as m
on c.Id = m.ChatId
where m.SentOn < '03.26.2012' and Title like '%x'