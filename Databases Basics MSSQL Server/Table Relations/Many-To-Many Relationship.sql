create table Students
(
StudentID int not null identity,
Name varchar(50)
)
go

create table Exams
(
ExamID int not null identity(101,1),
Name varchar(50)
)
go

create table StudentsExams
(
StudentID int not null,
ExamID int not null
)
go

insert into Students
values ('Mila'),
('Toni'),
('Ron')
go

insert into Exams
values ('SpringMVC'),
('Neo4j'),
('Oracle 11g')
go

insert into StudentsExams
values (1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103)
go

alter table Students
add constraint PK_Students primary key (StudentID)
go

alter table Exams
add constraint PK_Exams primary key (ExamID)
go

alter table StudentsExams
add constraint PK_StudentsExams primary key (StudentID, ExamID)
go

alter table StudentsExams
add constraint FK_Students_StudentsExams foreign key (StudentID) references Students(StudentID)
go

alter table StudentsExams
add constraint FK_Exams_StudentsExams foreign key (ExamID) references Exams(ExamID)
go