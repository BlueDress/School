select usage.ContinentCode, CurrenciesCount.CurrencyCode, usage.CurrencyUsage from
	(select CurrenciesCount.ContinentCode, max(CurrenciesCount.CurrencyCount) as CurrencyUsage from
		(select c.ContinentCode, c.CurrencyCode, count(c.CurrencyCode) as CurrencyCount from Countries as c
		group by c.CurrencyCode, c.ContinentCode) as CurrenciesCount
	group by CurrenciesCount.ContinentCode) as usage
inner join (select c.ContinentCode, c.CurrencyCode, count(c.CurrencyCode) as CurrencyCount from Countries as c
	group by c.CurrencyCode, c.ContinentCode) as CurrenciesCount
on usage.ContinentCode = CurrenciesCount.ContinentCode and usage.CurrencyUsage = CurrenciesCount.CurrencyCount
where usage.CurrencyUsage > 1
order by usage.ContinentCode