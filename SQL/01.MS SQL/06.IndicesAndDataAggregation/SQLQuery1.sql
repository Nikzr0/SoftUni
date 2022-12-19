----1
--select COUNT(*) from WizzardDeposits

----2
--select top(1) MagicWandSize from WizzardDeposits
--order by MagicWandSize desc

----3
--select  DepositGroup, max(MagicWandSize) from WizzardDeposits
--group by DepositGroup

----4
--select top(2)  DepositGroup from WizzardDeposits
--group by DepositGroup
--order by avg(MagicWandSize) asc

----5
--select DepositGroup, sum(DepositAmount) as DepAmount from WizzardDeposits
--group by DepositGroup 

----6
--select DepositGroup, sum(DepositAmount) as DepAmount from WizzardDeposits
--where lastname = 'Ollivander'
--group by DepositGroup 

----7

----8
--SELECT 
--	DepositGroup,
--	MagicWandCreator, 
--	MIN(DepositCharge) AS MinDepositCharge
--FROM WizzardDeposits
--GROUP BY DepositGroup, MagicWandCreator
--ORDER BY MagicWandCreator, DepositGroup

----9

--select ageRange, count(*) as WizzardCount
--from 
--	(
--	select 
--	case
--	when age <= 10 then '[0-10]'
--	when  age >= 11 and age <= 20 then '[11-20]'
--	when age >= 21 and  age <= 30 then '[21-30]'
--	when age >= 31 and age <= 40 then '[31-40]'
--	when age >= 41 and age <= 50 then '[41-50]'
--	when age >= 51 and age <= 60 then '[51-60]'
--	when age > 60 then '[61+]'
--	end as ageRange
--	from WizzardDeposits
--	) 
--	as p
--group by ageRange

----10
--SELECT LEFT(FirstName, 1)
--FROM WizzardDeposits
--WHERE DepositGroup = 'Troll Chest'
--GROUP BY LEFT(FirstName, 1)

----11
--select DepositGroup, IsDepositExpired, AVG(DepositInterest) as avarageInterest from WizzardDeposits
--where DepositStartDate > '01.01.1985'
--group by DepositGroup, IsDepositExpired
--order by depositgroup desc

----12
--SELECT SUM(CurrentDepositAmount - NextDepositAmount) FROM
--(SELECT
--	FirstName AS CurrentName,
--	DepositAmount AS CurrentDepositAmount,
--	LEAD(FirstName, 1) OVER (ORDER BY Id) AS NextName,
--	LEAD(DepositAmount, 1) OVER (ORDER BY Id) AS NextDepositAmount
--FROM WizzardDeposits) AS k

 --13
 select departmentid, Sum(salary) as totalSalary from employees
 group by  departmentid
 order by departmentid

 --14
 select departmentid, min(salary) from employees
 where DepartmentID in (2,5,7) and HireDate > '01.01.2000'
 group by DepartmentID

 --15

SELECT * INTO #EmployeesWithHighSalaries FROM Employees
WHERE Salary > 30000

DELETE FROM #EmployeesWithHighSalaries
WHERE ManagerID = 42

UPDATE #EmployeesWithHighSalaries
SET Salary = Salary + 5000
WHERE DepartmentID = 1

select AVG(salary) from  #EmployeesWithHighSalaries
group by DepartmentID

--16
select departmentid ,max(salary) from employees
where salary < 30000 or salary > 70000
Group by departmentId

--17
select count(*) from employees
where ManagerID is null

--18
select DepartmentId , Salary 
from 
(
	select
	DepartmentID,
	DENSE_RANK() over (partition by departmentid order by salary desc) as ranked,
	salary
	from Employees
) as k
where ranked = 3
group by DepartmentID, salary

--19

SELECT TOP(10) 
FIRSTNAME,
LASTNAME,
DEPARTMENTID
FROM EMPLOYEES E
WHERE 
SALARY > 
(
	SELECT AVG(SALARY)
	FROM EMPLOYEES
	WHERE DEPARTMENTID = E.DEPARTMENTID
	GROUP BY DEPARTMENTID
)
ORDER BY DEPARTMENTID