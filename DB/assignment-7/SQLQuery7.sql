--part 01 ITI

--1. Create a view that displays the student's full name, course name if the student has a grade more than 50.
GO
create view DisplayStudentData (FullName,CourseName)
with encryption
as 
select St_Fname +' '+St_Lname ,C.Crs_Name
from Student S ,Stud_Course SC ,Course C
where S.St_Id=SC.St_Id and SC.Crs_Id=c.Crs_Id and Grade>50
GO
select * from DisplayStudentData

--2.Create an Encrypted view that displays manager names and the topics they teach. 
Go
create or alter view DisplayManager(ManagerName,NameOfTopic)
with encryption
as 
select Ins.Ins_Name ,Top_Name
from Instructor ins ,Ins_Course IC ,Course C,Topic T
where Ins.Ins_Id=Ic.Ins_Id and C.Crs_Id=Ic.Crs_Id and C.Top_Id=T.Top_Id
Go
select * from DisplayManager

--3.Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department “use Schema binding” and describe what is the meaning of Schema Binding
Go
create or alter view GetDataOfIns 
WITH ENCRYPTION , SCHEMABINDING
as 
select Ins_Name ,Dept_Name
from  dbo.Department D, dbo.Instructor Ins
where D.Dept_Id=Ins.Dept_Id and Dept_Name in ('SD','Java')
GO
select * from GetDataOfIns

/*4. Create a view “V1” that displays student data for students who live in Alex or Cairo. 
Note: Prevent the users to run the following query 
Update V1 set st_address=’tanta’
Where st_address=’alex’;
*/
Go
create or alter view V1 
with encryption 
as 
select *
from dbo.Student 
where St_Address in ('Alex','Cairo')
with check option
Go
select * from V1

Go
Update V1 
set st_address='Tanta'
Where st_address='Alex';
Go

--5.Create a view that will display the project name and the number of employees working on it. (Use Company DB)
GO
create or alter view DisplayProject
with encryption
as 
select Pname,count(w.ESSn) as [Number Of Employee]
from Project P , Works_for W
where p.Pnumber=W.Pno
group by P.Pname
GO
select *from DisplayProject

--======================================================
--use CompanySD32_DB:
--1.Create a view named   “v_clerk” that will display employee Number ,project Number, the date of hiring of all the jobs of the type 'Clerk'.
Go
create or alter view v_clerk
with encryption 
as 
select EmpNo,ProjectNo ,Enter_Date
from Works_on
where Job='Clerk'
Go

select * from v_clerk

--2.Create view named  “v_without_budget” that will display all the projects data without budget
Go
create or alter view v_without_budget
with encryption 
as 
select ProjectNo ,ProjectName
from HR.Project
Go

select *from v_without_budget

--3.Create view named  “v_count “ that will display the project name and the Number of jobs in it
Go
create or alter view v_count 
with encryption 
as 
select P.ProjectName ,COUNT(w.Job) as [Number of Jobs]
from HR.Project p ,dbo.Works_on w
where P.ProjectNo =w.ProjectNo
group by p.projectName
GO
select * from v_count

--4.Create view named ” v_project_p2” that will display the emp# s for the project# ‘p2’ . (use the previously created view  “v_clerk”)
GO
create or alter view  v_project_p2
with encryption 
as 
select v.EmpNo [Employee Number] 
	from v_clerk V
	where V.ProjectNo = 2
Go
select * from v_project_p2


--5.modify the view named  “v_without_budget”  to display all DATA in project p1 and p2.
Go
 alter view v_without_budget
with encryption 
as 
select*
from HR.Project
where ProjectNo in (1,2)
Go
select *from v_without_budget

--6.Delete the views  “v_ clerk” and “v_count”
drop view v_clerk,v_count

--7.Create view that will display the emp# and emp last name who works on deptNumber is ‘d2’
GO
create or alter view DisplayEmp
with encryption
as 
select EmpNo,EmpLname
from HR.Employee
where DeptNo=2
Go
select * from DisplayEmp


--8.Display the employee  lastname that contains letter “J” (Use the previous view created in Q#7)
GO
create or alter view EmpLaname
with encryption
as 
select EmpLname
from DisplayEmp
where EmpLname  like 'J%'
GO
select * from EmpLaname


--9.Create view named “v_dept” that will display the department# and department name
GO
create or alter view v_dept 
with encryption
as 
select DeptNo,DeptName
from Department
Go
select * from v_dept

--10.using the previous view try enter new department data where dept# is ’d4’ and dept name is ‘Development’
insert into v_dept(DeptNo,DeptName)
values(5,'Development')


/*11.	Create view name “v_2006_check” that will display employee Number, 
the project Number where he works and the date of joining the project which must be from the first of January 
and the last of December 2006.this view will be used to insert data so make sure that the coming new data must match the condition.*/
GO
create or alter view v_2006_check 
with encryption
as 
select EmpNo,ProjectNo,Enter_Date
from Works_on W
where Enter_Date between '2006-1-1' and '2006-12-30'
with check option
 Go
 select * from v_2006_check

 insert into v_2006_check values(22222, 2, '2006-2-1') -- successful insertion
insert into v_2006_check values(22222, 1, '2007-2-1') -- failed because Date Range
