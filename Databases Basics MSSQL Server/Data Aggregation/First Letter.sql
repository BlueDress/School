select left(FirstName, 1) as FirstLetter from WizzardDeposits
where DepositGroup = 'Troll Chest'
group by left(FirstName, 1)
order by left(FirstName, 1)