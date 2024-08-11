--=============================================
--part01 //ITI

--1.	Select max two salaries in the instructor table. 
select top(2) Salary
from Instructor
order by Salary desc

--2.Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”
select *
from (
select salary , Dept_Id , 
	ROW_NUMBER() over (PARTITION by dept_id order by salary desc) as R 
from instructor) as newtable
where R<=2

--3. Write a query to select a random  student from each department.  “using one of Ranking Functions”
select * 
from (
select St_Fname , Dept_id , 
	ROW_NUMBER() over (partition by dept_id order by newid()) as RN
from Student) as newtable
where Dept_Id is not null and RN = 1 

--// my company
--1.Display the data of the department which has the smallest employee ID over all employees' ID.
select top(1) D.*
from Departments D, Employee E
where D.Dnum=E.Dno 
order by E.SSN 

select Dep.*
from Employee Emp , Departments Dep
where dep.Dnum = Emp.Dno 
and Emp.SSN = (select MIN(SSN) from Employee)

--2.List the last name of all managers who have no dependents.
select E.Lname
from Employee E, Dependent D
where E.SSN=D.ESSN and D.Dependent_name is null

select emp.Lname
from Employee emp , Departments dep 
where emp.SSN = dep.MGRSSN 
and emp.SSN  not in (select ESSN from Dependent) 


--3.For each department-- if its average salary is less than the average salary of all employees display its number, name and number of its employees.

select D.Dnum ,D.Dname ,count(E.SSN) [Number of employee]
 from Departments D,Employee E
 where D.Dnum=E.Dno 
 group by D.Dnum,D.Dname
 having AVG(E.Salary)< (select avg(salary) from Employee)


 --4.	Try to get the max 2 salaries using subquery
select *  from 
( 
select salary,

row_number () over (order by salary  desc) as RN
from Employee ) as Newtable

where RN in (1,2)


--5.Display the employee number and name if he/she has at least one dependent (use exists keyword) self-study
select distinct Fname , SSN
from Employee E , Dependent D
where D.ESSN = E.SSN  and  exists(select ESSN from Dependent)


--===========================================================================
-- part 02 
--1.Display the SalesOrderID, ShipDate of the SalesOrderHearder table (Sales schema) to designate SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2014’
select SalesOrderID , ShipDate
from Sales.SalesOrderHeader
where OrderDate between '7/28/2002' and '7/29/2014'


--2.Display only Products(Production schema) with a StandardCost below $110.00 (show ProductID, Name only)
select ProductID ,Name,StandardCost
from Production.Product
where StandardCost<110.00

--3.Display ProductID, Name if its weight is unknown
select ProductID ,Name
from Production.Product
where Weight is null

--4. Display all Products with a Silver, Black, or Red Color
select *
from Production.Product
where Color in ('Silver','Black','Red')

--5.Display any Product with a Name starting with the letter B
select *
from  Production.Product
where Name  like 'B%'

/* 6.	Run the following Query
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3
Then write a query that displays any Product description with underscore value in its description.
*/
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select *
from Production.ProductDescription
where Description like '%[_]%'


--7. Display the Employees HireDate (note no repeated values are allowed)
select Distinct HireDate
from HumanResources.Employee


--8.Display the Product Name and its ListPrice within the values of 100 and 120 the list should have the following format "The [product name] is only! [List price]" (the list will be sorted according to its ListPrice value)
select 'The[' + Name + '] is only!' + CONVERT(varchar(20), ListPrice)
from Production.Product
where ListPrice between 100 and 120
order by ListPrice

--================================================================
--part03 (functions) ITI

--1.Create a scalar function that takes a date and returns the Month name of that date.
Create Function GetMonthName (@date date)
returns varchar(20)
begin 
return format(getdate(),'MMMM')
end

select dbo.GetMonthName(getdate())

--2.Create a multi-statements table-valued function that takes 2 integers and returns the values between them.
Go
create function getValuesBetween2Int(@X int , @Y int)
returns @table table (valueINBetween int )
as
begin	
	while(@X < @Y - 1)
		begin 
			set @X += 1
			insert into @table values(@X)
		end
	return
end

GO
select * from getValuesBetween(1,10)


--3.Create a table-valued function that takes Student No and returns Department Name with Student full name.
GO
create function PrintDepartmentByStId (@st_Id int)
returns Table
as  
return (
select D.Dept_Name ,s.St_Fname +' ' + s.St_Lname [full name ]
from Student S,Department D
where S.Dept_Id=D.Dept_Id and @St_Id=St_Id
)
GO

select * from PrintDepartmentByStId(9)

/*4.Create a scalar function that takes Student ID and returns a message to user 

a.	If first name and Last name are null then display 'First name & last name are null'
b.	If First name is null then display 'first name is null'
c.	If Last name is null then display 'last name is null'
d.	Else display 'First name & last name are not null'
*/
GO
create or alter function PrintMessageById (@id int )
returns varchar(50) 
begin
declare @msg varchar(50)
declare @fname varchar(50)
declare @lname varchar(50)

select @fname=St_Fname ,@lname=St_Lname
from Student 
where @id=st_id
 
 if (@fname is null ) and (@lname is null ) 
  select @msg='First name & last name are null'

  else if (@fname is null ) 
  select @msg='First name is null'

  else if  (@lname is null ) 
  select @msg=' last name is null'

  else 
  select @msg='First name & last name are not null'

  return @msg
end
Go
select  dbo.PrintMessageById(3)


--5.Create a function that takes an integer which represents the format of the Manager hiring date and displays department name, Manager Name and hiring date with this format.  
create or alter function ManagerFormHiringDate(@format int)
returns @table table
(
	deptName varchar(50),
	mangerName varchar(50),
	hiringDate varchar(50)
)
as 
begin 
	insert into @table
	select D.Dept_Name, I.Ins_Name, convert(varchar(50), D.Manager_hiredate, @format)
	from Instructor I, Department D
	where D.Dept_Id = I.Dept_Id
	return
end
--Run
select * from ManagerFormHiringDate(111)

/*
6.	Create multi-statement table-valued function that takes a string
a.	If string='first name' returns student first name
b.	If string='last name' returns student last name 
c.	If string='full name' returns Full Name from student table  (Note: Use “ISNULL” function)
*/

Go
create function StudentName(@name varchar(50))
returns @Table Table(St_Fname varchar(50))
as 
begin
  
  if @name= 'first name'
  insert into @Table
  select isnull (St_Fname,'Not found')
  from student
  
  else if @name='last name'
  insert into @Table 
  select isnull (St_Lname ,'not found')
  from Student

   else if @name='full name'
   insert into @Table
   select isnull (St_Fname,'not found') + isnull (St_Lname ,'Not found ')
   from Student

   return

End

select * from dbo.StudentName('full name')



--7.Create function that takes project number and display all employees in this project (Use MyCompany DB)
Go
create or alter function DisplayEmpData (@projetnum int)
returns table
as 
return (
select E.Fname ,E.Lname
from Project P, Employee E ,Works_for W
where P.Pnumber=w.Pno and e.SSN =W.ESSn and @projetnum=Pnumber
)
Go
select *from dbo.DisplayEmpData(100)


create function getAllEmployees(@projectNo int)
returns @table table ( [Employee Name] varchar(50) )
as 

begin 
	insert into @table
	select CONCAT(E.Fname , E.Lname)
	from Employee E, Project P, Works_for W
	where P.Pnumber = W.Pno 
	and E.SSN = W.ESSn
	and P.Pnumber = @projectNo
	return 
end
--Run 
select * from getAllEmployees(100)
