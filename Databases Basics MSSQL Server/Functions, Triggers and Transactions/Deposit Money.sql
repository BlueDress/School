create proc usp_DepositMoney(@accountID int, @moneyAmount money) as
begin tran
update Accounts
set Balance += @moneyAmount
where Id = @accountID
commit
go