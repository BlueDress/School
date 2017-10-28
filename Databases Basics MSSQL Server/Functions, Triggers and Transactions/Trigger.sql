create trigger TR_PreventingBuyingHigherLevelWeapon on UserGameItems for insert as
if ((select MinLevel from Items) > (select Level from UsersGames))
begin
rollback
return
end
go

