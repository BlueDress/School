create proc usp_TransferMoney(@senderId int, @receiverId int, @amount money) as
begin
begin tran
if (@amount < 0)
begin
rollback
return
end
exec dbo.usp_WithdrawMoney @senderId, @amount;
exec dbo.usp_DepositMoney @receiverId, @amount;
commit
end
go