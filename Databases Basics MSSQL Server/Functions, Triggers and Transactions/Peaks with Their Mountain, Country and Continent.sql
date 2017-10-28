select p.PeakName, m.MountainRange as Mountain, c.CountryName, con.ContinentName from Peaks as p
inner join Mountains as m
on p.MountainId = m.Id
inner join MountainsCountries as mc
on m.Id = mc.MountainId
inner join Countries as c
on mc.CountryCode = c.CountryCode
inner join Continents as con
on c.ContinentCode = con.ContinentCode
order by p.PeakName, c.CountryName