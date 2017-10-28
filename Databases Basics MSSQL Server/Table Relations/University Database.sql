create table Majors
(
MajorID int primary key,
Name varchar(50)
)
go

create table Students
(
StudentID int primary key,
StudentNumber int,
StudentName varchar(50),
MajorID int foreign key references Majors(MajorID)
)
go

create table Payments
(
PaymentID int primary key,
PaymentDate date,
PaymentAmount money,
StudentID int foreign key references Students(StudentID)
)
go

create table Subjects
(
SubjectID int primary key,
SubjectName varchar(50)
)
go

create table Agenda
(
StudentID int not null foreign key references Students(StudentID),
SubjectID int not null foreign key references Subjects(SubjectID)
)
go

alter table Agenda
add constraint PK_Agenda primary key (StudentID, SubjectID)
go