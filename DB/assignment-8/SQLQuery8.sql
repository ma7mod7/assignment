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
--==============================================
--part03

--Department
create table Department (
DeptNo int primary key ,
DeptName varchar(50),
Location varchar(50) )

insert into Department
values (1,'Research','NY'),(2,'Accounting','DS'),(3,'Marketing','KW')


--Employee
Alter table Employees 
add foreign key (DeptNO) references Department(DeptNo)

--works_on
INSERT INTO Works_on
VALUES 
    (10102, 1, 'Analyst', '2006-10-01'),
    (10102, 3, 'Manager', '2012-01-01'),
    (25348, 2, 'Clerk', '2007-02-15'),
    (18316, 2, NULL, '2007-06-01'),
    (29346, 2, NULL, '2006-12-15'),
    (2581, 3, 'Analyst', '2007-10-15'),
    (9031, 1, 'Manager', '2007-04-15'),
    (28559, 1, NULL, '2007-08-01'),
    (28559, 2, 'Clerk', '2012-02-01'),
    (9031, 3, 'Clerk', '2006-11-15'),
    (29346, 1, 'Clerk', '2007-01-04');


--Testing Referential Integrity
--1-Add new employee with EmpNo =11111 In the works_on table [what will happen]
insert into Works_on(Empno) 
values (1111) --will not running because 

--2-Change the employee number 10102  to 11111  in the works on table [what will happen]
update Works_on
set EmpNo=11111
where EmpNo=10102 


--=======================================================
Alter Table Employees
Add TelephoneNumber  int 

alter table Employees
drop column TelephoneNumber
--=======================================================
/*2.	Create the following schema and transfer the following tables to it 
a.	Company Schema 
i.	Department table 
ii.	Project table 
b.	Human Resource Schema
i.	  Employee table 
*/
create schema company

alter schema company
transfer dbo.Department 


alter schema company
transfer dbo.project 

create schema HR

alter schema HR
transfer dbo.employees

--3.Increase the budget of the project where the manager number is 10102 by 10%.

update company.project 
set budget+=budget*0.1
from HR.employees E ,company.Project P ,Works_on W
where e.empno=w.EmpNo and p.projectno=w.ProjectNo and w.Job='manager' and w.EmpNo=10102

--4.Change the name of the department for which the employee named James works.The new department name is Sales.
update company.Department
set DeptName='sales'
from  company.Department D,HR.Employees E
where E.DeptNo=D.DeptNo and E.empFname='James'

--5.Change the enter date for the projects for those employees who work in project p1 and belong to department ‘Sales’. The new date is 12.12.2007.

update Works_on 
set Enter_Date= '12.12.2007'
from company.Department D,HR.Employees E,Works_on w
where E.DeptNo = D.DeptNo and  w.EmpNo=e.empno and  D.DeptName='Sales' and    w.ProjectNo=1


--6.Delete the information in the works_on table for all employees who work for the department located in KW.
delete from works_on
where empno in
 (select EmpNo
from Hr.employees e, company.Department D 
where E.deptno=D.deptno and d.location ='KW' )

--====================================================================
--part 04 ITI
--1.Create a trigger to prevent anyone from inserting a new record in the Department table ( Display a message for user to tell him that he can’t insert a new record in that table )
go
create trigger PreventInsertInDepartment
on Department
instead of insert
as 
print 'can’t insert a new record in that table'

insert into Department (Dept_Id)
values (50000)

--2.Create a table named “StudentAudit”. Its Columns are (Server User Name , Date, Note) 
create table StudentAudit 
( serverUserName varchar(50),
TheDate date ,
Note varchar(50)
)


/*
3.	Create a trigger on student table after insert to add Row in StudentAudit table 
•	 The Name of User Has Inserted the New Student  
•	Date
•	Note that will be like ([username] Insert New Row with Key = [Student Id] in table [table name]
*/
Go
create or alter  trigger T01
on Student 
after insert 
as 
declare @Note varchar(200),@st_id int 
select @st_id =st_id from inserted
select @Note=CONCAT(Suser_Name() ,'Insert New Row with Key= ',@st_id,'in table student')

insert into StudentAudit
values (Suser_Name(),GETDATE(),@Note)

insert into Student (St_Id)  values (2022) 
select * from StudentAudit


/*
4.	Create a trigger on student table instead of delete to add Row in StudentAudit table 
○	 The Name of User Has Inserted the New Student
○	Date
○	Note that will be like “try to delete Row with id = [Student Id]” 
*/
GO
create or alter trigger T02
on student
instead of Delete 
as
declare @Note varchar(100) ,@st_id2 int 
select  @st_id2= St_id from deleted
set @Note=CONCAT('try to delete Row with id= ',@st_id2)

insert into StudentAudit
values (SUSER_NAME(),GETDATE(),@Note)

delete from Student where St_Id=1
select *from StudentAudit


--5.Create a trigger that prevents the insertion Process for Employee table in March.//Use MyCompany DB:
Go
create trigger preventsInsertOnEmployee 
on Employee
instead of insert
as 
   begin 
   if FORMAT (Getdate(),'MMMM')='March'
   select 'can''t insert in this table '
   else 
   insert into Employee
   select * from inserted
   end
   insert into Employee (ssn,Lname) values (5645,'Ali')

   --==========================================================
   --part05
   --Use ITI DB :
   --1•	Create an index on column (Hiredate) that allows you to cluster the data in table Department. What will happen?
   create clustered index myIndex 
   on Department (Manager_hireDate)
   --Cannot create more than one clustered index on table 'Department'. Drop the existing clustered index 'PK_Department' before creating another.


   --2•	Create an index that allows you to enter unique ages in the student table. What will happen?
   create unique index myIndex2
   on student (st_age)

   --•	Try to Create Login Named(RouteStudent) who can access Only student and Course tables from ITI DB then allow him to select and insert data into tables and deny Delete and update
-- [Login]          Server (RouteStudent)
-- [User]           DB ITI (RouteStudent)
-- [Schema]         HR   [Student, Course]
-- Permissions      Grant [select,insert]    Deny [delete Update]