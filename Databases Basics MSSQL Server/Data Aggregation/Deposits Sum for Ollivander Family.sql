select DepositGroup, sum(DepositAmount) as TotalsSum from WizzardDeposits
where MagicWandCreator = 'Ollivander family'
group by DepositGroup