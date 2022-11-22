Create database Minions;
create table Minions
(
 Id int Primary Key,
 Name varchar(30),
 Age int 
)

create table Towns
(
Id int Primary Key,
Namе varchar(30)
) 

Alter Table Minions
Add TownId int; 

alter table Minions 
add foreign key (TownId) references Towns(Id);

select * from Minions;
select * from Towns;

Id	Name	Age	TownId		Id	Name
1	Kevin	22	1		1	Sofia
2	Bob	15	3		2	Plovdiv
3	Steward	NULL	2		3	Varna


Insert into Towns(Id, Namе) values
(1,'Sofia'),
(2,'Plovdiv'),
(3,'Varna')

Insert into Minions(Id,Name, Age, TownId) values
(1,'Kevin', 22, 1),
(2,'Bob', 15, 1),
(3,'Steward',null , 2)

create table people
(
  Id int unique identity,
  Name varchar(200) not null,
  Picture varbinary(Max),
  height decimal(12,2),
  weight  decimal(12,2),
  gender bit
)

create table Users
(
  Id int identity,
  Username varchar(200) unique not null,
  [Password] varchar(26) not null,
  ProfilePicture varchar(26),
  LostLogineTime Datetime,
  IsDelated bit
)

SELECT *
  FROM[Users]

Insert Into Users
(Username, [Password], LostLogineTime, IsDelated)
Values 
('Nikola', 'stongPassword234', '1/12/2002',0),
('Ivan', 'radfafsdf', '1/12/2003',0),
('Stefy', 'bhgsare4325',  '1/12/2004',0),
('Sam', 'gfdh435', '1/12/2006', 0),
('Sara', 'tgrfh2435', '1/12/2000',0)

--alter table Users 
--drop  constraint UQ__Users__536C85E4CF0B6949

--alter table users 
--add constraint Pk_IdUsername Primary Key (id, username)

--alter table Users
--add constraint CH_PasswordIsAtLeasr5Letters Check (Len(Password) > 5)

--alter table Users 
--add constraint defaultDate  default Getdate() for LostLogineTime

 EX 15
create database Hotel
create table Employee
(
Id int Primary Key,
FirstName varchar(20) not null,
LastName varchar(20)not null,
Title varchar(20),
Notes varchar(Max)
)

create table Customers
(
AccountNumber int primary key,
FirstName varchar(20)not null,
LastName varchar(20)not null,
PhoneNumber char(20) not null,
EmergencyName varchar(20) not null,
EmergencyNumber varchar(10)not null,
Notes varchar(Max)
)

create table RoomStatus
(
RoomStatus bit,
Note varchar(Max)
)
create table RoomTypes 
(
RoomType varchar(20)not null,
Note varchar(Max)
)
create table BedTypes 
(
BedType varchar(20) not null,
Note varchar(Max)
)
create table Rooms 
(
RoomNumber int primary key,
RoomType varchar(20) not null,
BedType varchar(20) not null,
Rate int,
RoomStatus varchar(20) not null,
Note varchar(Max)
)
create table Payments 
(
Id int primary key,
Employeeld int not null,
PaymentDate datetime not null,
AccountNumber int not null,
FirstDateOccupied datetime not null,
LastDateOccupied datetime not null,
TotalDays int not null,
AmountCharged decimal(18,2),
TaxRate decimal(18,2),
TaxAmount decimal(18,2),
PaymentTotal decimal(18,2),
Note varchar(Max)
)
create table Occupancies   
(
Id int Primary Key,
EmployeeId int not null,
DateOccupied datetime not null,
AccountNumber int not null,
RoomNumber int not null,
RateApplied int,
PhoneCharge decimal(15,3),
Note varchar(Max)
)

--Insert into Employee (...)
--Values (...)

--Insert into Customers  (...)
--Values (...)

--Insert into RoomStatus  (...)
--Values (...)

--Insert into RoomTypes  (...)
--Values (...)

--Insert into BedTypes  (...)
--Values (...)

--Insert into Rooms  (...)
--Values (...)

--Insert into Payments   (...)
--Values (...)

--Insert into Occupancies   (...)
--Values (... Gatedate())

-- 16
create database SoftUni

Create TABLE Towns
(
ID int Primary Key,
Name varchar (30) not null
)

Create TABLE Addresses
(
ID int Primary Key,
AddressText varchar(max),
TownId varchar (30) not null
)

Create TABLE Department
(
ID int Primary Key,
Name varchar (30) not null
)

Create TABLE Employee
(
ID int Primary Key identity,
FirstName varchar (30) not null,
MiddleName varchar (30),
LastName varchar (30) not null,
JobTitle varchar (30),
DepartmentId varchar(30) not null,
HireDate DateTime ,
Salary decimal(12,2),
AddressId varchar(30)
)

insert into Employee 
(ID,FirstName, MiddleName,LastName, JobTitle, DepartmentId, HireDate, Salary, AddressId)
Values
(1,'Nikola', 'Zaprinov', 'Pepelov','programmer', '302PD', '01/01/2022', 1670, 'Stefan Karadzha')

select FirstName, LastName, JobTitle, Salary, AddressId from Employee

Update Employee
set Salary= salary * 1.2
select * from Employee;

Update Employee
set Salary= salary / 1.2
select * from Employee;

DELETE FROM Employee WHERE Id = 1;
select * from Employee