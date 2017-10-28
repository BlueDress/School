create proc usp_GetTownsStartingWith (@firstLetter varchar) as
select Name from Towns
where left(Name, 1) = @firstLetter
go

exec usp_GetTownsStartingWith 'b'
go