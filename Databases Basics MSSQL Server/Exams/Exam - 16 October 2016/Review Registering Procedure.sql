create proc usp_SubmitReview(@CustomerID int, @ReviewContent varchar(255), @ReviewGrade int, @AirlineName varchar(30)) as
begin tran
if (@AirlineName not in (select AirlineName from Airlines))
begin
rollback
raiserror ('Airline does not exist.',16,2)
return
end
insert into CustomerReviews
values(@ReviewContent, @ReviewGrade, (select AirlineID from Airlines where AirlineName = @AirlineName), @CustomerID)
commit
go