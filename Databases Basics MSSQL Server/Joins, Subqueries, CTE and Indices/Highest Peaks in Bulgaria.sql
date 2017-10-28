select c.CountryCode, m.MountainRange, p.PeakName, p.Elevation from Countries as c
inner join MountainsCountries as mc
on c.CountryCode = mc.CountryCode
inner join Mountains as m
on mc.MountainId = m.id
inner join Peaks as p
on m.id = p.MountainId
where c.CountryCode = 'BG' and p.Elevation > 2835
order by p.Elevation desc