create table Cities
(
CityID int primary key,
Name varchar(50)
)
go

create table Customers
(
CustomerID int primary key,
Name varchar(50),
Birthday date,
CityId int foreign key references Cities(CityID)
)
go

create table Orders
(
OrderID int primary key,
CustomerID int foreign key references Customers(CustomerID)
)
go

create table ItemTypes
(
ItemTypeID int primary key,
Name varchar(50)
)
go

create table Items
(
ItemID int primary key,
Name varchar(50),
ItemTypeID int foreign key references ItemTypes(ItemTypeID)
)
go

create table OrderItems
(
OrderID int not null foreign key references Orders(OrderID),
ItemID int not null foreign key references Items(ItemID)
)
go

alter table OrderItems
add constraint PK_OrderItems primary key (OrderID,ItemID)