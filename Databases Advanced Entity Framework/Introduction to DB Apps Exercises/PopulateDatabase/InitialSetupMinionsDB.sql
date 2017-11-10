use MinionsDB

create table Towns
(
Id int identity,
Name varchar(50),
Country varchar(50),
constraint PK_Towns primary key (Id)
)

create table Minions
(
Id int identity,
Name varchar(50),
Age int,
TownId int,
constraint PK_Minions primary key (Id),
constraint FK_Minions_Towns foreign key (TownId) references Towns(Id)
)

create table Villains
(
Id int identity,
Name varchar(50),
[Evilness Factor] varchar(10),
constraint PK_Villains primary key (Id),
constraint CHK_EvilnessFactor check ([Evilness Factor] in ('good', 'bad', 'evil', 'super evil'))
)

create table VillainsMinions
(
VillainId int,
MinionId int,
constraint PK_VillainsMinions primary key (VillainId, MinionId),
constraint FK_VillainsMinions_Villains foreign key (VillainId) references Villains(Id),
constraint FK_VillainsMinions_Minions foreign key (MinionId) references Minions(Id)
)

insert into Towns values
('Sofia', 'Bulgaria'),
('Kyustendil', 'Bulgaria'),
('Paris', 'France'),
('London', 'England'),
('Barcelona', 'Spain')

insert into Minions values
('Bob', 8, 1),
('Kevin', 9, 3),
('Steward', 7, 4),
('Gary', 6, 5),
('Ilarion', 11, 2)

insert into Villains values
('Gru', 'good'),
('Dru', 'super evil'),
('Larry', 'bad'),
('Harry', 'evil'),
('Barry', 'evil')

insert into VillainsMinions values
(1, 1),
(1, 3),
(2, 2),
(2, 4),
(3, 3),
(3, 5),
(4, 4),
(4, 1),
(5, 5),
(5, 2)