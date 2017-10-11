select Username, substring(Email, charindex('@', Email) + 1, 200) as 'Email Provider' from Users
order by 'Email Provider', Username