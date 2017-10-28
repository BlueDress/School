create function udf_ExtractEmailProvider(@email varchar(max))
returns varchar(max)
as
begin
declare @result varchar(max);
declare @indexOf@ int = charindex('@', @email);
set @result = substring(@email, @indexOf@ + 1, len(@email) - @indexOf@);
return @result;
end
go

select dbo.udf_ExtractEmailProvider(Email) as 'Email Provider', count(*) as 'Number Of Users' from Users
group by dbo.udf_ExtractEmailProvider(Email)
order by 'Number Of Users' desc, 'Email Provider'
go