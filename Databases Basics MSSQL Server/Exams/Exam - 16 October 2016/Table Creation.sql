create table CustomerReviews
(
ReviewID int,
ReviewContent varchar(255) not null,
ReviewGrade	int not null check (ReviewGrade between 0 and 10),
AirlineID int, 
CustomerID int, 
constraint PK_CustomersReviews primary key (ReviewID),
constraint FK_CustomersReviews_AirlineID foreign key (AirlineID) references Airlines(AirlineID),
constraint FK_CustomersReviews_CustomerID foreign key (CustomerID) references Customers(CustomerID)
)
go


create table CustomerBankAccounts
(
AccountID int,
AccountNumber varchar(10) not null unique,
Balance	decimal(10,2) not null,
CustomerID int,
constraint PK_CustomerBankAccounts primary key (AccountID),
constraint FK_CustomerBankAccounts_Customers foreign key (CustomerID) references Customers(CustomerID)
)
go