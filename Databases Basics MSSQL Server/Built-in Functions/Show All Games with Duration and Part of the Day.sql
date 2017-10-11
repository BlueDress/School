select Name as Game, 
	case 
		when datepart(hour, Start) >= 0 and datepart(hour, Start) < 12 then 'Morning'
		when datepart(hour, Start) >= 12 and datepart(hour, Start) < 18 then 'Afternoon'
		when datepart(hour, Start) >= 18 and datepart(hour, Start) < 24 then 'Evening'
	end as 'Part of the Day',
	case
		when Duration <= 3 then 'Extra Short'
		when Duration between 4 and 6 then 'Short'
		when Duration > 6 then 'Long'
		else 'Extra Long'
	end as Duration
from Games
order by Game, Duration, 'Part of the Day'