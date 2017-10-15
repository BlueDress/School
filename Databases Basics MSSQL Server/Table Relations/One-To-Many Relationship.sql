create table Models
(
ModelID int not null identity(101,1),
Name varchar(50),
ManufacturerID int
)
go

create table Manufacturers
(
ManufacturerID int not null identity,
Name varchar(50),
EstablishedOn date
)
go

insert into Models
values ('X1',1),
('i6',1),
('ModelS',2),
('ModelX',2),
('Model3',2),
('Nova',3)
go

insert into Manufacturers
values ('BMW', '07/03/1916'),
('Tesla', '01/01/2003'),
('Lada', '01/05/1966')
go

alter table Models
add constraint PK_Models primary key (ModelID)
go

alter table Manufacturers
add constraint PK_Manufacturers primary key (ManufacturerID)
go

alter table Models
add constraint FK_Manufacturers_Models foreign key (ManufacturerID) references Manufacturers(ManufacturerID)
go