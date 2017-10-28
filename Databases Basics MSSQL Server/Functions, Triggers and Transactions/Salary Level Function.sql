create function ufn_GetSalaryLevel(@salary money) 
returns varchar(7)
as
begin
declare @result varchar(7)
if (@salary < 30000)
begin
set @result = 'Low'
end
else if (@salary <= 50000)
begin
set @result = 'Average'
end
else
begin
set @result = 'High'
end
return @result
end