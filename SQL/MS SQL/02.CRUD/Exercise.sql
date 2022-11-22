Select Name From [dbo].[Departments]

Select FirstName, MiddleName, LastName From Employees

select * From Employees

select  FirstName + ' ' + MiddleName + ' ' + LastName as FullName From Employees 

select  FirstName, LastName  From Employees 
where ManagerID is null

select * From Employees
where Salary > 50000

select Top(10) * From Employees
where Salary > 50000

select * From Employees
where JobTitle not Like '%Marketing%'

select * From Employees
order by salary desc, FirstName, LastName desc, MiddleName

Create view v_EmployeesSalaries
As
select FirstName, LastName, Salary
from Employees;

select distinct JobTitle From Employees

select top(10) * From Projects
order by StartDate

select Top(7) * from Employees
order by HireDate desc

Update Employees
set Salary = Salary * 1.2

-- Second Part
select MountainRange from [dbo].[Mountains]

select CountryName from Countries

select CountryName, CountryCode, CurrencyCode From Countries

-- Third Part

Select Name From Characters
