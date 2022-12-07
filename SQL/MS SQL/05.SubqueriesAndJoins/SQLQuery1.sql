
---- 1
--select  top (5) EmployeeID, Jobtitle, e.AddressID , addresstext from Employees as e
--join Addresses a on e.AddressId = a.AddressID
--order by addressid

----2
--select  top (50)
--name,addresstext from addresses as a
--join towns t on a.townID = t.townID
--order by name asc

----3
--select EmployeeID, firstName, LastName, e.DepartmentID from Employees as e
--join departments as d on e.DepartmentID = d.DepartmentID 
--where d.name = 'Sales'
--order by EmployeeID asc

----4
--select top (5) EmployeeID, firstname, Salary, d.name  from Employees e
--join Departments d on  e.AddressID = d.DepartmentID
--where e.Salary > 15000
--order by e.DepartmentID asc

----5
--select top(3) EmployeeID, FirstName from Employees e
--full join projects p on e.EmployeeID = p.ProjectID
--where ProjectId is null
--order by EmployeeID asc

----6

--select firstname, lastname, hiredate, d.name from Employees e
--full join Departments d on e.DepartmentID = d.DepartmentID
--where HireDate > '1.1.1999' and d.Name = 'Sales' or d.name = 'Finance'
--order by HireDate asc

----7 
--select top(5) e.EmployeeID, e.FirstName, p.Name from Employees e
--full join EmployeesProjects ep on  e.EmployeeID = ep.EmployeeID
--full join Projects p on ep.ProjectID = p.ProjectID
--where HireDate < '13.08.2002' and EndDate is null

----8 (not fully compleated)
--select top(5) e.EmployeeID, e.FirstName, p.Name from Employees e
--full join EmployeesProjects ep on  e.EmployeeID = ep.EmployeeID
--full join Projects p on ep.ProjectID = p.ProjectID
--where e.EmployeeID  = 24

----9
--select * from Employees
--where ManagerID in (3,7)
--order by EmployeeID asc

----10
--select top(50) EmployeeID, firstname, d.name from Employees e
--full join Departments d on  e.DepartmentID = d.DepartmentID

----11

--select min(salary) from Employees
--group by DepartmentID

--SELECT top(1) AVG(salary) as a 
--FROM Employees
--GROUP BY DepartmentID
--order by a asc

--12
select CountryCode, MountainRange, peakname, Elevation from Mountains m
full join  Peaks p on m.id = p.MountainId
full join  MountainsCountries mc on p.MountainId = mc.MountainId
where CountryCode = 'BG' and Elevation > 2835

--13
select CountryCode, count(CountryCode) as MountainRanges from MountainsCountries
where CountryCode in ('Us','Ru','BG')
group by CountryCode

--14
select  c.CountryName, r.RiverName from Countries c
full join CountriesRivers cr on c.CountryCode = cr.CountryCode 
full join Rivers r on cr.RiverId = r.Id 
full join Continents con on c.ContinentCode = con.ContinentCode
where con.ContinentCode = 'AF'
order by c.CountryName asc

--15 (not full)
select con.ContinentCode,  count(curr.CurrencyCode) as CurrencyUsage from Countries c
full join Currencies curr on c.CurrencyCode = curr.CurrencyCode
full join Continents con on c.ContinentCode = con.ContinentCode
group by con.ContinentCode

--16
select count(c.CountryCode) from MountainsCountries mc
full join Countries c on mc.CountryCode = c.CountryCode
where mc.MountainId is  null

--17
SELECT 
	c.CountryName,
	MAX(p.Elevation) AS HighestPeakElevation,
	MAX(r.Length) AS LongestRiverLength
FROM Countries c 
	LEFT JOIN MountainsCountries mc ON c.CountryCode = mc.CountryCode
	LEFT JOIN Mountains m ON m.Id = mc.MountainId
	LEFT JOIN Peaks p ON p.MountainId = m.Id

	LEFT JOIN CountriesRivers cr ON c.CountryCode = cr.CountryCode
	LEFT JOIN Rivers r ON r.Id = cr.RiverId
GROUP BY CountryName
ORDER BY HighestPeakElevation DESC, LongestRiverLength DESC

--18
SELECT TOP(1000) 
	ISNULL(Country, '(no highest peak)'),
	ISNULL([Highest Peak Name], '(no highest peak)'),
	ISNULL([Highest Peak Elevation], 0),
	ISNULL(Mountain, '(no mountain)')
FROM 
	(SELECT 
		DENSE_RANK() OVER (PARTITION BY CountryName ORDER BY MAX(Elevation) DESC) AS [Rank],
		CountryName AS Country, 
		PeakName AS [Highest Peak Name],
		MAX(Elevation) AS [Highest Peak Elevation], 
		MountainRange Mountain
	FROM Peaks p
		RIGHT JOIN Mountains m ON m.Id = p.MountainId
		RIGHT JOIN MountainsCountries mc ON mc.MountainId = m.Id
		RIGHT JOIN Countries c ON c.CountryCode = mc.CountryCode
	GROUP BY CountryName, PeakName, MountainRange) AS nfo
WHERE Rank = 1
ORDER BY Country ASC, [Highest Peak Elevation] DESC