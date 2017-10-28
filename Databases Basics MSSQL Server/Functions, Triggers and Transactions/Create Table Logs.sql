create table Logs
(
LogId int identity primary key,
AccountId int foreign key references Accounts(Id),
OldSum money,
NewSum money
)
go

create trigger tr_AccountsBalanceChange on Accounts for update as
begin
insert into Logs(AccountId, OldSum, NewSum)
select i.Id, d.Balance, i.Balance from inserted as i
inner join deleted as d
on i.Id = d.Id
end
go