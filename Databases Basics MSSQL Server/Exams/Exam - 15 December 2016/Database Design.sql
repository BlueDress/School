create table Locations
(
Id int identity,
Latitude decimal(18,8),	
Longitude decimal(18,8),
constraint PK_Locations primary key (Id)
)
go

create table Credentials
(
Id int identity,
Email varchar(30),
Password varchar(20),	
constraint PK_Credentials primary key (Id)
)
go

create table Users
(
Id int identity,
Nickname varchar(25),	
Gender varchar(1),	
Age int,
LocationId int,
CredentialId int unique,
constraint PK_Users primary key (Id),
constraint FK_Users_Locations foreign key (LocationId) references Locations(Id),
constraint FK_Users_Credentials foreign key (CredentialId) references Credentials(Id)
)
go

create table Chats
(
Id int identity,
Title varchar(32),
StartDate date,	
IsActive bit,
constraint PK_Charts primary key (Id)
)
go

create table Messages
(
Id int identity,
Content varchar(200),	
SentOn date,
ChatId int,
UserId int,
constraint PK_Messages primary key (Id),
constraint FK_Messages_Chats foreign key (ChatId) references Chats(Id),
constraint FK_Messages_Users foreign key (UserId) references Users(Id)
)
go

create table UsersChats
(
UserId int,
ChatId int,
constraint PK_UsersChats primary key (UserId, ChatId),
constraint FK_UsersChats_UsersID foreign key (UserId) references Users(Id),
constraint FK_UsersChats_ChatsID foreign key (ChatId) references Chats(Id)
)
go