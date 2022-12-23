--1
--create database MinionsDB

-- create table Countries (id int primary key identity, Name varchar(30) )

-- create table Towns (id int primary key identity, Name varchar(30), CountyCode varchar(30) )

-- Create table Minions ( id int primary key identity, Name varchar(30), Age int, TownID int references Towns(id) )

-- create table EvilnessFactors ( id int primary key identity, Name varchar(30) )

-- create table Villains ( id int primary key identity, Name varchar(30), EcilnessFactorIndex int references EvilnessFactors(id))

-- create table MinionsVillains ( MinionId int references Minions(id), VillainId int references Villains(id) constraint PK_MinionsVillains Primary key(MinionId, VillainId))


--INSERT INTO Countries (Id, Name) VALUES (1, 'Bulgaria'), (2, 'Norway'), (3,'Cyprus'), (4, 'Greece'), (5, 'UK')

--INSERT INTO Towns (Id, Name, CountyCode) VALUES (1, 'Plovdiv', 1), (2, 'Oslo', 2), (3, 'Larnaca', 3), (4, 'Athens', 4), (5, 'London', 5)

--INSERT INTO Minions VALUES (1, 'Stoyan', 12, 1), (2, 'George', 22, 2), (3, 'Ivan', 25, 3), (4, 'Kiro', 35, 4), (5, 'Niki', 25, 5)

--INSERT INTO EvilnessFactors VALUES (1, 'super good'), (2, 'good'), (3, 'bad'),(4, 'evil1'), (5, 'super evil')

--INSERT INTO Villains VALUES (1, 'Gru', 1), (2, 'Ivo', 2), (3, 'Teo', 3),(4, 'Sto', 4),(5, 'Pro', 5)

--INSERT INTO MinionsVillains VALUES (1,1), (2,2), (3,3), (4,4), (5,5)

--2

--SELECT Name, COUNT(mv.MinionId) as MinionCount
--FROM Villains AS v
--JOIN MinionsVillains AS mv ON v. Id = mv.VillainId
--GROUP BY v.Id, v.Name
--having COUNT(mv.MinionId) > 3
--order by MinionCount desc

--3

