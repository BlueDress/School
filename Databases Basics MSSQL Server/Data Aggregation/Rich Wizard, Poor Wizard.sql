select sum(Difference)
from (select 
FirstName, 
DepositAmount, 
lead(FirstName) over (order by Id) as NextWizard, 
lead(DepositAmount) over (order by Id) as NextDeposit ,
DepositAmount - lead(DepositAmount) over (order by Id) as Difference
from WizzardDeposits) as TempTable
