select Title, IsActive from Chats
where (IsActive = 0 and len(Title) < 5) or Title like '__tl%'
order by Title desc