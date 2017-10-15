create table Persons
(
PersonID int not null,
FirstName varchar(50),
Salary money,
PassportID int not null
)
go

create table Passports
(
PassportID int not null,
PassportNumber varchar(50)
)
go

insert into Persons
values (1, 'Roberto',43300.00 ,102 ),
(2, 'Tom',56100.00 ,103 ),
(3, 'Yana',60200.00 ,101 )
go

insert into Passports
values (101, 'N34FG21B'),
(102, 'K65LO4R7'),
(103, 'ZE657QP2')
go

alter table Persons
add constraint PK_Persons primary key (PersonID)
go

alter table Passports
add constraint PK_Passports primary key (PassportID)
go

alter table Persons
add constraint FK_Passports_Persons foreign key (PassportID) references Passports(PassportID)
go