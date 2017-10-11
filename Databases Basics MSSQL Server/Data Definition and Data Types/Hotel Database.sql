create database Hotel

create table Employees 
(
Id int identity primary key not null, 
FirstName nvarchar(50) not null, 
LastName nvarchar(50) not null, 
Title nvarchar(50) not null, 
Notes nvarchar(max)
)

create table Customers 
(
AccountNumber int primary key not null, 
FirstName nvarchar(50) not null, 
LastName nvarchar(50) not null, 
PhoneNumber int not null, 
EmergencyName nvarchar(50) not null, 
EmergencyNumber int not null, 
Notes nvarchar(max)
)

create table RoomStatus 
(
RoomStatus nvarchar(100) primary key, 
Notes nvarchar(max)
)

create table RoomTypes  
(
RoomType nvarchar(100) primary key, 
Notes nvarchar(max)
)

create table BedTypes 
(
BedType nvarchar(100) primary key, 
Notes nvarchar(max)
)

create table Rooms 
(
RoomNumber int primary key not null, 
RoomType nvarchar(100) not null, 
BedType nvarchar(100) not null, 
Rate money not null, 
RoomStatus nvarchar(100) not null, 
Notes nvarchar(max)
)

create table Payments 
(
Id int identity primary key not null, 
EmployeeId int not null, 
PaymentDate date not null, 
AccountNumber int not null, 
FirstDateOccupied date not null, 
LastDateOccupied date not null, 
TotalDays int not null, 
AmountCharged money not null, 
TaxRate money not null, 
TaxAmount money not null, 
PaymentTotal money not null, 
Notes nvarchar(max)
)

create table Occupancies 
(
Id int identity primary key not null, 
EmployeeId int not null, 
DateOccupied date not null, 
AccountNumber int not null, 
RoomNumber int not null, 
RateApplied money not null, 
PhoneCharge money, 
Notes nvarchar(max)
)

insert into Employees(FirstName, LastName, Title)
values ('Пържи', 'Трътков', 'Наблюдател'),('Пържи', 'Трътков', 'Наблюдател'),('Пържи', 'Трътков', 'Наблюдател')

insert into Customers(AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber)
values (0000, 'Ягода', 'Вампирска', 000, 'Малина Вампирска', 111),
(0001, 'Ягода', 'Вампирска', 000, 'Малина Вампирска', 111),
(0002, 'Ягода', 'Вампирска', 000, 'Малина Вампирска', 111)

insert into RoomStatus(RoomStatus)
values ('a'),('b'),('c')

insert into RoomTypes(RoomType)
values ('a'),('b'),('c')

insert into BedTypes(BedType)
values ('a'),('b'),('c')

insert into Rooms(RoomNumber, RoomType, BedType, Rate, RoomStatus)
values (101, 'a', 'a', 100, 'a'),(102, 'a', 'a', 100, 'a'),(103, 'a', 'a', 100, 'a')

insert into Payments(EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal)
values (1, '2000-01-01', 0000, '2000-01-01', '2000-01-02', 1, 100, 10, 10, 110),
(1, '2000-01-01', 0000, '2000-01-01', '2000-01-02', 1, 100, 10, 10, 110),
(1, '2000-01-01', 0000, '2000-01-01', '2000-01-02', 1, 100, 10, 10, 110)

insert into Occupancies(EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied)
values (1, '2000-01-01', 0000, 101, 10),
(1, '2000-01-01', 0000, 101, 10),
(1, '2000-01-01', 0000, 101, 10)