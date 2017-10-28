create proc usp_GetHoldersWithBalanceHigherThan (@number money) as
select ah.FirstName, ah.LastName from
(select a.AccountHolderId, sum(a.Balance) as TotalBalance from Accounts as a
group by a.AccountHolderId) as TotalBalanceByPerson
inner join AccountHolders as ah
on TotalBalanceByPerson.AccountHolderId = ah.Id
where TotalBalanceByPerson.TotalBalance >= @number
go