create database relations

create table Passports
(
PassportID int Primary key,
PassportNumber varchar(30) unique
)

create table Persons
(
PersonId int Primary key,
FirstName varchar(30),
 salary decimal(10,2),
 PassportID int references Passports(PassportID)
)

insert into Passports(PassportID, PassportNumber)
Values (101, 'N34FG21B'),
(102, 'K65LO4R7'),
(103, 'ZE657QP2')

insert into Persons(PersonId,FirstName, salary, PassportID)
values (1, 'Roberto', 43300.00,102),
(2, 'Tom', 56100.00,103),
(3, 'Yana', 60200.00,101)



-- 05

create database restaurant
create table Cities
(
   CitieID int primary key,
   Name varchar(50)
)

create table Customers
(
   CustomerId int primary key,
   Name varchar(50),
   Birthday datetime,
   cityId int references Cities(CitieID)
)

create table Orders
(
   OrderID int primary key,
   customerID int references Customers(CustomerId)
)

create table OrderItems
(
   OrderID int primary key references Orders(orderId),
   ItemID int
)

create table Items
(
   ItemID int primary key references OrderItems(OrderID),
   Name Varchar(50),
)

create table ItemType
(
   ItemID int primary key references Items(ItemID),
   Name Varchar(50)
)

select * from Mountains
select * from Peaks


select MountainRange, PeakName, Elevation From Mountains
Join  Peaks on Mountains.id = Peaks.mountainid 
where MountainRange = 'Rila'
order by Elevation Desc