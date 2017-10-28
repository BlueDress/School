select u.Nickname, c.Email, c.Password from Users as u
inner join Credentials as c
on u.CredentialId = c.Id
where c.Email like '%co.uk'
order by c.Email