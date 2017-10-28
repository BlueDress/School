create function ufn_IsWordComprised(@setOfLetters varchar(max), @word varchar(max)) 
returns bit
as
begin
declare @index int = 1;
declare @charToCheck  varchar(1);
declare @wordToCheck varchar(max);
declare @wordToCheckFrom varchar(max);
if (len(@setOfLetters) >= len(@word))
begin
set @wordToCheck = @setOfLetters;
set @wordToCheckFrom = @word;
end
else
begin
set @wordToCheck = @word;
set @wordToCheckFrom = @setOfLetters;
end
while (@index <= len(@wordToCheck))
begin
set @charToCheck = substring(@wordToCheck, @index, 1);
if (charindex(@charToCheck, @wordToCheckFrom) < 1)
begin
return 0;
end
set @index += 1;
end
return 1;
end
go