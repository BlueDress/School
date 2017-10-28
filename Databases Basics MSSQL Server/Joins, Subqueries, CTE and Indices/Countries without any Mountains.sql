select count(*) as CountryCode from Countries as c
left join MountainsCountries as mc
on c.CountryCode = mc.CountryCode
where mc.MountainId is null