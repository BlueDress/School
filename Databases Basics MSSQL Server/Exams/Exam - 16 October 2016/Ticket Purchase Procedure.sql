create proc usp_PurchaseTicket (@CustomerID int, @FlightID int, @TicketPrice decimal(8,2), @Class varchar(6), @Seat varchar(5)) as
begin tran
declare @userBalance decimal(10,2) = (select Balance from CustomerBankAccounts where CustomerID = @CustomerID);
if (@userBalance < @TicketPrice)
begin
rollback
raiserror('Insufficient bank account balance for ticket purchase.',16,2)
return
end
declare @TicketId int = isnull((select max(TicketID) from Tickets), 0) + 1
insert into Tickets
values(@TicketId, @TicketPrice, @Class, @Seat, @CustomerID, @FlightID)
update CustomerBankAccounts
set Balance -= @TicketPrice
where CustomerID = @CustomerID
commit
go