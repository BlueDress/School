create table People(
Id int identity primary key,
Name nvarchar(200) not null,
Picture image,
Height float,
Weight float,
Gender varchar(1) check(Gender in('m', 'f')) not null,
Birthdate date not null,
Biography nvarchar(max)
);

insert into People (Name, Height, Weight, Gender, Birthdate, Biography)
values ('���� �������� ����������', 1.90, 90.50, 'm', '2000-01-01', 'a'),
('���� �������� ����������', 1.90, 90.50, 'm', '2000-01-01', 'b'),
('���� �������� ����������', 1.90, 90.50, 'm', '2000-01-01', 'c'),
('���� �������� ����������', 1.90, 90.50, 'm', '2000-01-01', 'd'),
('���� �������� ����������', 1.90, 90.50, 'm', '2000-01-01', 'e');