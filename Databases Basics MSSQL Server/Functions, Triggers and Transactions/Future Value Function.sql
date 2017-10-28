create function ufn_CalculateFutureValue(@sum money, @interestRate float, @years int)
returns float
as
begin
declare @result float;
set @result = @sum * (POWER(1 + @interestRate, @years))
return @result;
end
go
