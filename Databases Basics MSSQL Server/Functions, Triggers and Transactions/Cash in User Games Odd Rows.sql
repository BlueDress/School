create function ufn_CashInUsersGames (@GameName nvarchar(50))
returns @SumCashTable table (SumCash money)
as
begin
insert into @SumCashTable (SumCash)
select sum(rn.Cash) 
from    (select ug.GameId, ug.Cash,
        ROW_NUMBER() over (partition by ug.GameId order by ug.GameId desc) as 'RowNumber'
        from UsersGames as ug
        inner join Games as g
		on ug.GameId = g.Id
        where g.Name = @GameName) as rn
        where rn.RowNumber % 2 != 0
return
end 
go