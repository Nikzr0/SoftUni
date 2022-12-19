--1
--drop database CigarShop
create database CigarShop

Use CigarShop

create table Sizes
(
id int primary key identity,
length int CHECK (length BETWEEN 10 and 25) not null,
RingRange decimal(18,2) CHECK (RingRange BETWEEN 1.5 and 7.5) not null
)

create table Tastes
(
id int primary key identity,
TasteType nvarchar(20) not null,
TasteStrength nvarchar(15) not null,
ImageURL nvarchar(100) not null
)

create table Brands
(
id int primary key identity,
BrandName nvarchar(30) unique not null,
BrandDescription nvarchar(max)
)

create table Cigars
(
id int primary key identity,
CigarName nvarchar(80) not null,
BrandId int REFERENCES  Brands(id),
TastId int References Tastes(id),
SizeId int references Sizes(id) not null,
PriceForSingleCigar money not null,
ImageURL nvarchar(100) not null
)

create table Addresses
(
id int primary key identity,
Town  nvarchar(30) not null,
Country nvarchar(30) not null,
Streat nvarchar(100) not null,
ZIP nvarchar(20) not null
)

create table Clients
(
id int primary key identity,
FirstName nvarchar(30)  not null,
LastName nvarchar(30)  not null,
Email nvarchar(50)  not null,
AddressId int References Addresses(id) not null
)

create table ClientsCigars
(
ClientId int  References Clients(id),
CigarId int  references Cigars(id),
Primary Key(ClientId, CigarId)
)

--2
insert into Cigars(cigarname, brandid, tastid,sizeid,priceforsinglecigar,imageurl) 
values ('COHIBA ROBUSTO',	9,	1,	5,	15.50,	'cohiba-robusto-stick_18.jpg'),
('COHIBA SIGLO I',	9,	1,	10,	410.00,	'cohiba-siglo-i-stick_12.jpg'),
('HOYO DE MONTERREY LE HOYO DU MAIRE',	14,	5,	11,	7.50,	'hoyo-du-maire-stick_17.jpg'),
('HOYO DE MONTERREY LE HOYO DE SAN JUAN',	14,	4,	15,	32.00,	'hoyo-de-san-juan-stick_20.jpg'),
('TRINIDAD COLONIALES',	2,	3,	8,	85.21,	'trinidad-coloniales-stick_30.jpg')

insert into addresses (town, country, streat,zip)
values ('Athens', 'Greece',	'4342 McDonald Avenue',	10435),
('Zagreb',	'Croatia',	'4333 Lauren Drive',	10000)

--3
select * from cigars c
join tastes t on c.tastid = t.id
where TasteType = 'Spicy'
update Cigars set priceforsinglecigar += (priceforsinglecigar / 5)

--4
select * from addresses
delete from addresses where country like 'c%'

--5 
select cigarName, PriceForSingleCigar, ImageURL from cigars
order by PriceForSingleCigar , cigarname desc  

--6
select c.id, CigarName, PriceForSingleCigar, TasteType, TasteStrength from Cigars c
join Tastes t on c.TastId = t.id
where TasteType = 'Earthy' or TasteType = 'Woody'
order by PriceForSingleCigar desc

--7
select id, FirstName + ' ' + lastname as FullName, Email from Clients
where id not in(select distinct clientId from ClientsCigars)
order by FullName asc

--8  
select CigarName, PriceForSingleCigar, ImageURL from Cigars c
join Sizes s on c.SizeId = s.id
where s.length >= 12 and CigarName like'%ci%' or PriceForSingleCigar > 50 and RingRange > 2.55
order by c.CigarName asc, c.PriceForSingleCigar desc

--9
SELECT  FULLNAME,COUNTRY,ZIP, PRICEFORSINGLECIGAR FROM 
(
 SELECT ROW_NUMBER() OVER(PARTITION BY FIRSTNAME + ' ' + LASTNAME ORDER BY C.PRICEFORSINGLECIGAR DESC) AS ROW_NUMBER,
 FIRSTNAME + ' ' + LASTNAME AS FULLNAME, COUNTRY,ZIP,C.PRICEFORSINGLECIGAR FROM CIGARS C
 JOIN CLIENTSCIGARS CC ON C.ID = CC.CIGARID
 JOIN CLIENTS CL ON CC.CLIENTID = CL.ID
 JOIN ADDRESSES A ON CL.ADDRESSID = A.ID
 WHERE ZIP NOT LIKE '%[^0-9]%'
) AS K
WHERE ROW_NUMBER = 1

--10
select cl.LastName, AVG(s.length) as AvgCigarName, ceiling(avg(RingRange)) from cigars c
join clientscigars cc on c.id = cc.cigarid
join clients cl on cc.clientid = cl.id
join Sizes s on c.SizeId = s.id
group by lastname
order by AvgCigarName desc

--11
CREATE FUNCTION udf_ClientWithCigars(@FirstName nvarchar(30))
RETURNS nvarchar(30)
AS 
BEGIN
    DECLARE @Count int;
    SET @Count = 
	(
		select count(c.id) from cigars c
		join clientscigars cc on c.id = cc.cigarid
		join clients cl on cc.clientid = cl.id
		join Sizes s on c.SizeId = s.id
		group by cl.FirstName
		having cl.FirstName = @FirstName
	)
    RETURN @Count
END

select dbo.udf_ClientWithCigars('Betty')

--12
create Procedure usp_SearchByTaste @taste nvarchar(30)
as
	Select c.CigarName, CONCAT('$', c.PriceForSingleCigar) as Price, t.TasteType, b.BrandName, Concat(s.length, 'cm') as CigarLength, Concat(s.RingRange, 'cm') as CigarRingRange from Cigars c
	join Sizes s on c.SizeId = s.id
	join Tastes t on c.TastId = t.id
	join brands b on c.BrandId = b.id
	where t.TasteType = @taste
	order by CigarLength asc, CigarRingRange desc
go

EXEC usp_SearchByTaste 'Woody'