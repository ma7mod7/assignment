--=============================================
--Part 01
--1.Create a stored procedure to show the number of students per department.[use ITI DB] 
create Proc ShowNumberOfStudent 
as 
select Dept_Name ,count(St_Id) [Number of Student per Department]
from Student S join Department D on S.Dept_Id=D.Dept_Id
group by Dept_Name,D.Dept_Id
GO
ShowNumberOfStudent

--2.Create a stored procedure that will check for the Number of employees in the project 100 
--if they are more than 3 print message to the user “'The number of employees in the project 100 is 3 or more'”
--if they are less display a message to the user “'The following employees work for the project 100'” in addition to the first name and last name of each one. [MyCompany DB]
GO
create Proc CheckNumberOfEmployees
as
	declare @x int
	Select @x = count(ESSN)
	from Works_for
	where PNo = 100
	if(@x > 3)
		Select 'The number of employees in the project number 100 is 3 or more'
	else
		Select ' The following employees work for the project number 100 : '
		Select FName + ' '+ LName [Full Name]
		from Employee E, Works_for W
		where E.SSN = W.ESSN and W.PNo = 100
--Run
CheckNumberOfEmployees
GO


--3.Create a stored procedure that will be used in case an old employee has left the project and a new one becomes his replacement.
--The procedure should take 3 parameters (old Emp. number, new Emp. number and the project number) and it will be used to update works_on table. [MyCompany DB]
create proc UpdateEmpData @oldEmpNum int ,@NewEmpNum int , @ProjectNum int
as 
Update Works_for
set ESSN=@NewEmpNum
where ESSN=@oldEmpNum and Pno=@ProjectNum

execute  UpdateEmpData 102672,102660,100


--4.	Create an Audit table with the following structure 
--ProjectNo 	UserName 	ModifiedDate 	Budget_Old 		Budget_New 
--100			Dbo 		2008-01-31		95000 			200000 

--This table will be used to audit the update trials on the Budget column (Project table, SD32-Company DB)
--Example:
--If a user updated the budget column then the project number, username that made that update, the date of the modification and the value of the old and the new budget will be inserted into the Audit table
--Note: This process will take place only if the user updated the budget column
GO
Create table AuditUpdateOnBudget
(
 ProjectNo int,
 UserName  varchar(50),
 ModifiedDate  date,
 Budget_Old  int,
 Budget_New int
)
GO
Create  or alter trigger hr.UpdateBudget
on hr.Project
after Update
as
	if Update(Budget)
	begin
		declare @PNum int, @oldBudget int, @newBudget int
		select @oldBudget = Budget from deleted
		Select @newBudget = Budget from inserted
		Select @PNum = ProjectNo from deleted

		insert into AuditUpdateOnBudget
		values(@PNum, suser_name(),  getdate(), @oldBudget, @newBudget)
	end

update HR.Project
	set Budget = 250
	where ProjectNo = 2

select * from AuditUpdateOnBudget

--==========================================================
--Part 02
--1.Create a stored procedure that calculates the sum of a given range of numbers
GO
create proc CalcSum @start int ,@end int ,@Sum int output
as 
Begin 
set @sum=0
  while @start<=@end
   begin 
     set @sum+=@start
     set @start+=1
   end

end

Declare @Result Int 
exec  CalcSum  @start=1,@end=10,@Sum=@Result output
select @Result


--2.Create a stored procedure that calculates the area of a circle given its radius
GO
create or alter proc CalcAreOfCircle @radius float,@area float output
as 
begin
set @area=PI() *POWER(@radius,2)
end

declare @restult float 
exec CalcAreOfCircle @radius=5,@area=@restult output
select round(@restult,4)


--3.Create a stored procedure that calculates the age category based on a person's age ( Note: IF Age < 18 then Category is Child and if  Age >= 18 AND Age < 60 then Category is Adult otherwise  Category is Senior)
Go
create proc CalcAge @age int,@Category varchar(20) output
as 
begin 
  if(@age<18)
    set @Category='Child '
  else if (@age>=18 and @age<60)
    set @Category='Adult'
  else 
  set @Category='Senior'

end

declare @Cate varchar(20) 
exec CalcAge @age=18,@Category=@Cate output
select @Cate as [age category]


--4.Create a stored procedure that determines the maximum, minimum, and average of a given set of numbers ( Note : set of numbers as Numbers = '5, 10, 15, 20, 25')
GO
CREATE PROCEDURE CalculateStatistics
    @Numbers VARCHAR(MAX),
    @MaxValue INT OUTPUT,
    @MinValue INT OUTPUT,
    @Average FLOAT OUTPUT
AS
BEGIN
    CREATE TABLE #TempNumbers (Value INT);
    
    INSERT INTO #TempNumbers (Value)
    SELECT Value
    FROM STRING_SPLIT(@Numbers, ',');
    
    SELECT @MaxValue = MAX(Value), @MinValue = MIN(Value), @Average = AVG(Value)
    FROM #TempNumbers;
    
    DROP TABLE #TempNumbers;
END;
GO

DECLARE @MaxValue INT;
DECLARE @MinValue INT;
DECLARE @Average FLOAT;
EXEC CalculateStatistics @Numbers = '5, 10, 15, 20, 25', @MaxValue = @MaxValue OUTPUT, @MinValue = @MinValue OUTPUT, @Average = @Average OUTPUT