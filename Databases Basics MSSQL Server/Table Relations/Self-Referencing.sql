create table Teachers
(
TeacherID int not null identity(101,1),
Name varchar(50) not null,
ManagerID int 
)
go

insert into Teachers
values ('John', null),
('Maya', 106),
('Silvia', 105),
('Ted', 105),
('Mark', 101),
('Greta', 101)
go

alter table Teachers
add constraint PK_Teachers primary key (TeacherID)
go

alter table Teachers
add constraint FK_Teachers foreign key (ManagerId) references Teachers(TeacherID)
go