create database Movies

create table Directors
(
Id int identity not null primary key,
DirectorName nvarchar(100) not null,
Notes nvarchar(max)
)

create table Genres
(
Id int identity not null primary key,
GenreName nvarchar(100) not null,
Notes nvarchar(max)
)

create table Categories
(
Id int identity not null primary key,
CategoryName nvarchar(100) not null,
Notes nvarchar(max)
)

create table Movies
(
Id int identity not null primary key,
Title nvarchar(255) not null,
DirectorId int,
CopyrightYear int,
Length float(1),
GenreId int,
CategoryId int,
Rating float(1),
Notes nvarchar(max)
)

insert into Directors(DirectorName)
values ('Гъргорин Тъпчилещов'),('Гъргорин Тъпчилещов'),('Гъргорин Тъпчилещов'),('Гъргорин Тъпчилещов'),('Гъргорин Тъпчилещов')

insert into Genres(GenreName)
values ('Документална порнография'),('Документална порнография'),('Документална порнография'),('Документална порнография'),('Документална порнография')

insert into Categories(CategoryName)
values ('TBC'),('TBC'),('TBC'),('TBC'),('TBC')

insert into Movies(Title)
values ('Тайните помисли на стария дъб'),('Тайните помисли на стария дъб'),('Тайните помисли на стария дъб'),('Тайните помисли на стария дъб'),('Тайните помисли на стария дъб')