update Countries
set CountryName = 'Burma'
where CountryName = 'Myanmar'
go

insert into Monasteries
values ('Hanga Abbey', (select CountryCode from Countries where CountryName = 'Tanzania'))
go

insert into Monasteries
values ('Myin-Tin-Daik', (select CountryCode from Countries where CountryName = 'Myanmar'))
go

select CountriesAndContinents.ContinentName, 
CountriesAndContinents.CountryName,
MonasteriesCountByCountry.MonasteriesCount
from (select c.CountryName, count(*) as MonasteriesCount from Countries as c
left join Monasteries as m
on c.CountryCode = m.CountryCode
where c.IsDeleted = 0
group by c.CountryName) as MonasteriesCountByCountry
inner join (select c.CountryName, con.ContinentName from Countries as c
inner join Continents as con
on c.ContinentCode = con.ContinentCode) as CountriesAndContinents
on MonasteriesCountByCountry.CountryName = CountriesAndContinents.CountryName
order by MonasteriesCountByCountry.MonasteriesCount desc, CountriesAndContinents.CountryName
go