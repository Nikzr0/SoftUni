--1
--create procedure dbo.FirstAndLastName
--as
--select firstname, lastname from Employees
--where salary > 35000
--go

--Exec dbo.FirstAndLastName

--2

--create procedure dbo.sp_aboveNumber @Number decimal(18,4)
--as
--select FirstName, lastname from employees
--where Salary >= @Number
--go

--Exec dbo.sp_aboveNumber @Number = 48100

----3
--create procedure usp_GetTownsStartingWith @Str nvarchar(max)
--as
--select name from towns
--WHERE LEFT (Name,1) IN (@Str)
--go

--Exec usp_GetTownsStartingWith @Str = 'b'

--4
--create procedure usp_GetEmployeesFromTown (@TownName nvarchar(max))
--as
--select firstName, lastname from employees
--where AddressID =

--(select top(1) addressId from addresses
--where townid = 

--(select top(1) townId from towns
--where name = @TownName))
--go

--exec usp_GetEmployeesFromTown @TownName = 'Sofia'

--5
--CREATE FUNCTION ufn_GetSalaryLevel(@SALARY DECIMAL(18,4))
--RETURNS VARCHAR(max)
--AS
--BEGIN 	

--DECLARE @SALARYLEVEL NVARCHAR(MAX)

--	  IF (@SALARY < 30000)
--        SET @SALARYLEVEL = 'LOW'
--    ELSE IF (@SALARY BETWEEN 30000 AND 50000)
--        SET @SALARYLEVEL = 'AVERAGE'
--    ELSE
--        SET @SALARYLEVEL = 'HIGH'

--    RETURN @SALARYLEVEL
--END

--SELECT
--  Salary,
--  dbo.ufn_GetSalaryLevel(Salary) AS [Salary Level]
--FROM Employees


--6
--create procedure sp_EmployeesBySalary(@SalaryLevel varchar(max))
--as
--select
--firstname,
--lastname
--from Employees
--WHERE dbo.ufn_GetSalaryLevel(Salary) = @SalaryLevel
--go

--exec sp_EmployeesBySalary 'Low'

--7
--CREATE FUNCTION ufn_IsWordComprised
--  (
--  @setOfLetters nvarchar(max), 
--  @word nvarchar(max)
--  )
--RETURNS bit
--AS
--BEGIN 
--    SET @word = REPLACE(@word, char(9), '')
--    SET @word = RTRIM(LTRIM(@word))
--    DECLARE @l int = 1;
--    WHILE LEN(@word) >= @l
--    BEGIN
--      DECLARE @charindex int; 
--      DECLARE @letter char(1);
--      SET @letter = SUBSTRING(@word, @l, 1)
--      SET @charindex = CHARINDEX(@letter, @setOfLetters, 0)
--      IF @charindex = 0
--      BEGIN 
--        RETURN 0
--      END
--      SET @setOfLetters = STUFF(@setOfLetters, @charindex, 1, '')
--      SET @l += 1;
--    END

--    RETURN 1
--END
--8
-- 'PK_DepartmentID' is not a constraint. (Error)
create procedure usp_DeleteEmployeesFromDepartment (@departmentId INT) 
as
ALTER TABLE Departments  
DROP Constraint [DepartmentID];   

DELETE FROM Employees WHERE DepartmentID = @departmentId;
DELETE FROM Departments WHERE DepartmentID = @departmentId;
go

Exec usp_DeleteEmployeesFromDepartment 7


-- I don't habe the DB yet
--9