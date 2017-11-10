use MinionsDB

select m.Name, m.Age from Villains as v
inner join VillainsMinions as vm
on v.Id = vm.VillainId
inner join Minions as m
on m.id = vm.MinionId
where v.Id = @villainId