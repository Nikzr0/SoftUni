--1
select FirstName, LastName from Employees
where FirstName like 'Sa%'

--2
select * from employees
where LastName like '%ei%'

--3
select * from Employees 
where DATEPART(year, HireDate) between 1995 and 2005
and
departmentId = 3 or departmentId = 10 

--4
select FirstName, LastName from employees
where JobTitle not like '%engineer%'

--5
select Name from towns 
where Len(Name) = 5 or Len(Name) = 6
order by name asc

--6
select * from Towns
WHERE Name LIKE 'M%'
AND Name LIKE 'K%'
AND Name LIKE 'B%'
AND Name LIKE 'E%'
order by name asc

--7
select * from Towns
WHERE Name Not LIKE 'B%'
AND Name Not LIKE 'R%'
AND Name not LIKE 'D%'
order by name asc

--8
--Go
--Create view V_AllManAfter2000
--AS
SELECT FirstName, LastName
FROM Employees
WHERE  DATEPART(year, HireDate) > 2000
--select * from V_AllManAfter2000

--9
select FirstName, LastName from Employees
where  len(LastName) = 5

--10
select EmployeeID, Firstname, LastName, salary, 
 DENSE_RANK() OVER   
    (partition by salary order by EmployeeId) AS Rank 
	from Employees
	where Salary between 10000 and 50000 
		order by Salary desc

--11
select EmployeeID, Firstname, LastName, salary, rank from 
(
	select EmployeeID, Firstname, LastName, salary, 
 DENSE_RANK() OVER   
    (partition by salary order by EmployeeId) AS Rank 
	from Employees
		where Salary between 10000 and 50000 
		--order by Salary desc
) as tablename
where Rank = 2
order by Salary desc

--12
select CountryName, IsoCode from Countries 
WHERE CountryName LIKE '%a%a%a%'
order by CountryName asc

13

-- not ready
select PeakName,
rivername,
lower(left,(peakname) - 1) - 1) + rivername) as Mix
from peaks, rivers
where right(peakname,1) = left(rivername, 1)
order by mix


14
select top(50)
CONVERT(date, start, 101),
Name
from Games
where datepart(year, start) = 2011 or datepart(year, start) = 2012
order by start

--15
select * from 
(
select
UserName,
SUBSTRING (Email, CHARINDEX( '@', [Email]) + 1,
LEN(Email) ) AS [Domain]
from Users
) as PeopleAndDomains
order by [Domain] asc

--16
select username, ipAddress from users 
where ipaddress like '[0-9][0-9][0-9].1%.%.[0-9][0-9][0-9]'

--17



--18
create table Original
(
id int primary key identity,
ProductName varchar(30),
Orderdata datetime
)

insert into Original(ProductName,Orderdata)
values
('Butter',	2016-09-19),
('Milk',	2016-09-30),
('Cheese',	2016-09-04),
('Bread',	2015-12-20),
('Tomatoes',	2015-12-30)

select 
ProductName,
Orderdata,
DATEADD(day, 3, Orderdata) AS PayDue,
DATEADD(month, 1, Orderdata) AS DeliveryDue
from Original
select * from original

--19

create table PersonBirth
(
id int primary key identity,
name varchar(40),
Birthdate datetime
)

insert into PersonBirth(name, Birthdate)
values
('Victor',	2000-12-07),
('Steven',	1992-09-10),
('Stephen',	1910-09-19),
('John',	2010-01-06)

select 
DATEDIFF(year,Birthdate,GETDATE()) AS years,
DATEDIFF(month,Birthdate,GETDATE()) AS months,
DATEDIFF(day,Birthdate,GETDATE()) AS days,
DATEDIFF(HOUR,Birthdate,GETDATE()) AS hours,
DATEDIFF(MINUTE,Birthdate,GETDATE()) AS minutes
from PersonBirth