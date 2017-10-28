declare @userID int = (select Id from Users where Username = 'Stamat')
declare @gameID int = (select Id from Games where Name = 'Safflower')
declare @userGameID int = (select Id from UsersGames where UserId = @userID and GameId = @gameID)

begin try
begin tran
update UsersGames
set Cash -= (select sum(Price) from Items where MinLevel in (11, 12))
where Id = @userGameID
declare @userBalance decimal(15, 4) = (select cash from UsersGames where id = @userGameID)
if(@userBalance < 0)
begin
rollback
return
end
insert into UserGameItems
select Id, @userGameID from Items where MinLevel in (11, 12)
commit
end try
begin catch
rollback
end catch

begin try
begin tran
update UsersGames
set Cash -= (select sum(Price) from Items where MinLevel in (19, 20, 21))
where Id = @userGameID
set @userBalance = (select cash from UsersGames where id = @userGameID)
if(@userBalance < 0)
begin
rollback
return
end
insert into UserGameItems
select Id, @userGameID from Items where MinLevel in (19, 20, 21)
commit
end try
begin catch
rollback
end catch

select i.Name as 'Item Name' from Items as i
inner join UserGameItems as ugi
on i.Id = ugi.ItemId
where ugi.UserGameId = @userGameID
order by 'Item Name'