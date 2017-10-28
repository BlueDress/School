select c.CurrencyCode, c.Description as Currency, CurrencyUsageCountByCountries.NumberOfCountries from
(select CurrencyCode, count(*) as NumberOfCountries from Countries
group by CurrencyCode) as CurrencyUsageCountByCountries
inner join Currencies as c
on CurrencyUsageCountByCountries.CurrencyCode = c.CurrencyCode
order by NumberOfCountries desc, Currency
