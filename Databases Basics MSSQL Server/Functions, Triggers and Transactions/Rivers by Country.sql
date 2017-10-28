select CountriesByContinent.CountryName, 
CountriesByContinent.ContinentName,
RiversCountAndTotalLenghtByCountry.RiversCount,
RiversCountAndTotalLenghtByCountry.TotalLength
from 
(select c.CountryName, con.ContinentName from Countries as c
inner join Continents as con
on c.ContinentCode = con.ContinentCode) as CountriesByContinent
inner join 
(select c.CountryName, count(r.Id) as RiversCount, sum(r.Length) as TotalLength from Countries as c
left join CountriesRivers as cr
on c.CountryCode = cr.CountryCode
left join Rivers as r
on cr.RiverId = r.Id
group by c.CountryName) as RiversCountAndTotalLenghtByCountry
on CountriesByContinent.CountryName = RiversCountAndTotalLenghtByCountry.CountryName
order by RiversCount desc, TotalLength desc, CountryName