update Chats
set StartDate = 
(select min(m.SentOn) from Chats as c
inner join Messages as m
on c.Id = m.ChatId
where c.Id = Chats.Id
)
where Chats.Id in 
(select c.Id from Chats as c
inner join Messages as m
on c.Id = m.ChatId
group by c.Id, c.StartDate
having c.StartDate > min(m.SentOn)
)