create table NotificationEmails
(
Id int identity primary key, 
Recipient int, 
Subject varchar(max), 
Body varchar(max)
)
go

create trigger TR_LogsAfterInsert on Logs for Insert as
begin
insert into NotificationEmails(Recipient, Subject, Body)
select 
l.AccountId, 
'Balance change for account:' + l.AccountId as Subject,
 'On ' + getdate() + ' your balance was changed from ' + l.OldSum + ' to ' + l.NewSum + '.' as Body
from Logs as l
end
go