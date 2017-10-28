select c.CountryName, max(p.Elevation) as HighestPeakElevation, max(r.Length) as LongestRiverLength from Countries as c
left join CountriesRivers as cr
on c.CountryCode = cr.CountryCode
left join Rivers as r
on cr.RiverId = r.Id
left join MountainsCountries as mc
on c.CountryCode = mc.CountryCode
left join Mountains as m
on mc.MountainId = m.Id
left join Peaks as p
on m.Id = p.MountainId
group by c.CountryName
order by max(p.Elevation) desc, max(r.Length) desc, c.CountryName