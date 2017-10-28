select top 5 c.Id, count(*) as TotalMessages from Messages as m
inner join Chats as c
on m.ChatId = c.Id
where m.Id < 90
group by c.Id
order by TotalMessages desc