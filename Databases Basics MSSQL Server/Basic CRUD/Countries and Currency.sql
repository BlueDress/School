select CountryName, CountryCode, Currency =
case CurrencyCode
when 'EUR' then 'Euro'
else 'Not Euro'
end
from Countries
order by CountryName