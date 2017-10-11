select top(50) Name, datefromparts(datepart(year, Start), datepart(month, Start), datepart(day, Start)) as Start from Games
where datepart(year, Start) in (2011, 2012)
order by Start, Name