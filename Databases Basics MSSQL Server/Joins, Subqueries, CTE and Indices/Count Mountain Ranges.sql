select mc.CountryCode, count(*) as MountainRanges from MountainsCountries as mc
--inner join Countries as c
--on mc.CountryCode = c.CountryCode
where mc.CountryCode in ('BG', 'US', 'RU')
group by mc.CountryCode