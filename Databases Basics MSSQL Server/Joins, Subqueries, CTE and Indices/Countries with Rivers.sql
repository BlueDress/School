select top 5 c.CountryName, r.RiverName from Countries as c
left join CountriesRivers as cr
on c.CountryCode = cr.CountryCode
left join Rivers as r
on cr.RiverId = r.id
inner join Continents as con
on c.ContinentCode = con.ContinentCode
where con.ContinentName = 'Africa'
order by c.CountryName