use MinionsDB

select v.Name, count(*) as MinionsCount from Villains as v
inner join VillainsMinions as vm
on v.Id = vm.VillainId
group by v.Name
having count(*) > 1
order by count(*)