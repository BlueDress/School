create table Flights
(
FlightID int,
DepartureTime datetime not null, 
ArrivalTime datetime not null,
Status varchar(9) not null check (Status in ('Departing', 'Delayed', 'Arrived', 'Cancelled')),
OriginAirportID int,
DestinationAirportID int,
AirlineID int
constraint PK_Flights primary key (FlightID),
constraint FK_Airports_Flights foreign key(OriginAirportID) references Airports(AirportID),
constraint FK_Flights_Airports foreign key(DestinationAirportID) references Airports(AirportID),
constraint FK_Airports_Airlines foreign key(AirlineID) references Airlines(AirlineID)
)
go

create Table Tickets
(
TicketID int,
Price decimal(8,2) not null,
Class varchar(6) not null check(Class in ('First', 'Second', 'Third')),
Seat varchar(5) not null,
CustomerID int,
FlightID int,
constraint PK_Tickets primary key (TicketID),
constraint FK_Tickets_Customers foreign key (CustomerID) references Customers(CustomerID),
constraint FK_Tickets_Flights foreign key (FlightID) references Flights(FlightID)
)
go