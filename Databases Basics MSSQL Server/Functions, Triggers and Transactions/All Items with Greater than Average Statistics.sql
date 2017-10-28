select
i.Name, 
i.Price, 
i.MinLevel, 
s.Strength, 
s.Defence, 
s.Speed, 
s.Luck, 
s.Mind 
from Items as i
inner join [dbo].[Statistics] as s
on i.StatisticId = s.Id
left join (select avg(Speed) as avgSpeed, avg(Luck) as avgLuck, avg(Mind) as avgMind from [dbo].[Statistics]) as avgStats
on s.Speed > avgStats.avgSpeed and s.Luck > avgStats.avgLuck and s.Mind > avgStats.avgMind
where avgStats.avgSpeed is not null
order by i.Name