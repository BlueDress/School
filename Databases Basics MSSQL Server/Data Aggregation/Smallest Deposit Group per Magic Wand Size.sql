select DepositGroup from WizzardDeposits 
group by DepositGroup
having avg(MagicWandSize) = (
select min(AverageSizes) as MinimalAverageSize from (
select avg(MagicWandSize) as AverageSizes from WizzardDeposits 
group by DepositGroup) as WandSizeTable
)