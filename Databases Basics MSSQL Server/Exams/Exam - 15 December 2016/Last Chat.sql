select top 1 c.Title, m.Content from Chats as c
left join Messages as m
on c.Id = m.ChatId
order by StartDate desc, SentOn 