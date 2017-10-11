create database CarRental

create table Categories 
(
Id int identity primary key not null,
CategoryName nvarchar(100) not null,
DailyRate float,
WeeklyRate float,
MonthlyRate float,
WeekendRate float
)

create table Cars 
(
Id int identity primary key not null, 
PlateNumber nvarchar(20) not null, 
Manufacturer nvarchar(100) not null, 
Model nvarchar(100) not null, 
CarYear int, 
CategoryId int, 
Doors int, 
Picture nvarchar(max), 
Condition nvarchar(255), 
Available bit
)

create table Employees 
(
Id int identity primary key not null,
FirstName nvarchar(100) not null, 
LastName nvarchar(100) not null, 
Title nvarchar(100) not null, 
Notes nvarchar(max)
)

create table Customers 
(
Id int identity primary key not null,
DriverLicenceNumber nvarchar(50), 
FullName nvarchar(100) not null, 
Address nvarchar(255) not null, 
City nvarchar(50) not null, 
ZIPCode nvarchar(20) not null, 
Notes nvarchar(max) 
)

create table RentalOrders 
(
Id int identity primary key not null, 
EmployeeId int not null, 
CustomerId int not null, 
CarId int not null, 
TankLevel int, 
KilometrageStart int not null, 
KilometrageEnd int not null, 
TotalKilometrage int not null, 
StartDate date not null, 
EndDate date not null, 
TotalDays int not null, 
RateApplied money not null, 
TaxRate money not null, 
OrderStatus nvarchar(max), 
Notes nvarchar(max)
)

insert into Categories(CategoryName)
values ('Economy'),('Economy'),('Economy')

insert into Cars(PlateNumber, Manufacturer, Model)
values ('KH 1983 BH', 'Трабант', 'Super Nitro V64'),('KH 1983 BH', 'Трабант', 'Super Nitro V64'),('KH 1983 BH', 'Трабант', 'Super Nitro V64')

insert into Employees(FirstName, LastName, Title)
values ('Рачо', 'Китов', 'Оператор на калкулатор'),('Рачо', 'Китов', 'Оператор на калкулатор'),('Рачо', 'Китов', 'Оператор на калкулатор')

insert into Customers(FullName, Address, City, ZIPCode)
values ('Испиридон Буков', 'ул. Сама Каща 1', 'Длъхчево Сабляр', '42'),('Испиридон Буков', 'ул. Сама Каща 1', 'Длъхчево Сабляр', '42'),('Испиридон Буков', 'ул. Сама Каща 1', 'Длъхчево Сабляр', '42')

insert into RentalOrders(EmployeeId, CustomerId, CarId, KilometrageStart, KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate)
values (1, 1, 1, 100, 200, 100, '2000-01-01', '2000-01-02', 1, 100, 10),
(1, 1, 1, 100, 200, 100, '2000-01-01', '2000-01-02', 1, 100, 10),
(1, 1, 1, 100, 200, 100, '2000-01-01', '2000-01-02', 1, 100, 10)