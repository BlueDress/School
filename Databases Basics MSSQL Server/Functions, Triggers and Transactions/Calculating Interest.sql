create proc usp_CalculateFutureValueForAccount as
select 
a.Id as 'Account Id', 
ah.FirstName, ah.LastName, 
a.Balance as 'Current Balance', 
dbo.ufn_CalculateFutureValue(a.Balance, 0.1, 5) as 'Balance in 5 years' 
from Accounts as a
inner join AccountHolders as ah
on a.AccountHolderId = ah.Id
go

