create table Users
(
Id bigint identity primary key,
Username varchar(30) unique not null,
Password varchar(26) not null,
ProfilePicture varbinary(max),
LastLoginTime date,
IsDeleted varchar(5) check (IsDeleted in ('true', 'false'))
);

alter table Users
add constraint SC_ProfilePicture check (datalength(ProfilePicture) < 900 * 1024)

insert into Users (Username, Password, LastLoginTime, IsDeleted)
values ('Иларион Макариополски', '123456', '2000-01-01', 'false'),
('Иларион Макариополски Втори', '1234567', '2000-01-01', 'true'),
('Иларион Макариополски Трети', '12345678', '2000-01-01', 'false'),
('Иларион Макариополски Четвърти', '123456789', '2000-01-01', 'true'),
('Иларион Макариополски Пети', '1234567890', '2000-01-01', 'false');