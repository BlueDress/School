select DepositGroup, max(MagicWandSize) as LongestMagicWand from WizzardDeposits
group by DepositGroup
order by LongestMagicWand