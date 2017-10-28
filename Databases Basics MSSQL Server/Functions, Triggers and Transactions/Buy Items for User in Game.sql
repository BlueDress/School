declare @userId int = (select Id from Users where Username = 'Alex');
declare @userGameId int = (select Id from UsersGames where GameId = (select Id from Games where Name = 'Edinburgh'));
declare @blackguardId int = (select Id from Items where Name = 'Blackguard');
declare @bottomlessPotionofAmplificationId int = (select Id from Items where Name = 'Bottomless Potion of Amplification');
declare @eyeofEtlichDiabloIIIId int = (select Id from Items where Name = 'Eye of Etlich (Diablo III)');
declare @gemofEfficaciousToxinId int = (select Id from Items where Name = 'Gem of Efficacious Toxin');
declare @goldenGorgetofLeoricId int = (select Id from Items where Name = 'Golden Gorget of Leoric');
declare @hellfireAmuletId int = (select Id from Items where Name = 'Hellfire Amulet');

begin tran 
update UsersGames
set Cash -= ((select Price from Items where Id = @blackguardId) + 
(select Price from Items where Id = @bottomlessPotionofAmplificationId) + 
(select Price from Items where Id = @eyeofEtlichDiabloIIIId) +
(select Price from Items where Id = @gemofEfficaciousToxinId) +
(select Price from Items where Id = @goldenGorgetofLeoricId) +
(select Price from Items where Id = @hellfireAmuletId)) where UserId = @userId;

insert into UserGameItems
values(@userGameId, @blackguardId),
(@userGameId, @bottomlessPotionofAmplificationId),
(@userGameId, @eyeofEtlichDiabloIIIId),
(@userGameId, @gemofEfficaciousToxinId),
(@userGameId, @goldenGorgetofLeoricId),
(@userGameId, @hellfireAmuletId);
commit
go

select u.Username, g.Name, ug.Cash, i.Name as 'Item Name' from Games as g
inner join UsersGames as ug
on g.Id = ug.GameId
inner join Users as u
on ug.UserId = u.Id
inner join UserGameItems as ugi
on ug.Id = ugi.UserGameId
inner join Items as i
on ugi.ItemId = i.Id
where g.Name = 'Edinburgh'
order by i.Name
go