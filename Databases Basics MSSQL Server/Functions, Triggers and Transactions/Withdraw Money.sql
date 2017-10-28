create proc usp_WithdrawMoney (@accountId int, @moneyAmount money) as
begin
begin tran
update Accounts
set Balance = Balance - @moneyAmount
where Id = @accountId
if @@ROWCOUNT != 1
begin
rollback
raiserror('Invalid account!', 16, 1)
return
end
commit
end
go