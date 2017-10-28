select con.ContinentName, 
sum(cast(c.AreaInSqKm as bigint)) as CountriesArea, 
sum(cast(c.Population as bigint)) as CountriesPopulation 
from Countries as c
inner join Continents as con
on c.ContinentCode = con.ContinentCode
group by con.ContinentName
order by CountriesPopulation desc