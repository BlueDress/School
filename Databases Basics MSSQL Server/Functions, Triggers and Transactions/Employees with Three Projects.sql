create proc usp_AssignProject(@emloyeeId int, @projectID int) as
declare @projectsOfEmployee int;
set @projectsOfEmployee = (select count(*) as ProjectsCount from EmployeesProjects as ep where ep.EmployeeID = @emloyeeId)
begin tran
insert into EmployeesProjects(EmployeeID, ProjectID)
values (@emloyeeId, @projectID)
if (@projectsOfEmployee >= 3)
begin
rollback
raiserror('The employee has too many projects!', 16, 1)
return
end
else
begin
commit
end