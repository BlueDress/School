select i.Name as Item, i.Price, i.MinLevel, gt.Name as 'Forbidden Game Type' from Items as i
inner join GameTypeForbiddenItems as gtf
on i.Id = gtf.ItemId
inner join GameTypes as gt
on gtf.GameTypeId = gt.Id
order by gt.Name desc, i.Name