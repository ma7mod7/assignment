

--======================================================================================--
--Part 01 //ITI
--1.Retrieve a number of students who have a value in their age. 
select count(*) as [number of student]
from Student
where St_Age is not null


--2.Display number of courses for each topic name 
select T.Top_Name ,count(C.Crs_Id) as [number of courses]
from Course C, Topic T
where T.Top_Id=C.Top_Id
group by T.Top_Name


--3.Select Student first name and the data of his supervisor 
select s.St_Fname,sp.*
from Student s,Student sp
where sp.St_Id=s.St_super

--4.	Display student with the following Format (use isNull function)
--Student ID | Student Full Name | Department name
select St_Id,CONCAT(IsNull(St_Fname,'not found'),' ',isNull(St_Lname,'not found')) FullName ,D.Dept_Name DepartmentName
from Student S,Department D
where s.Dept_Id=D.Dept_Id

--5.Select instructor name and his salary but if there is no salary display value �0000� . �use one of Null Function� 
select Ins_Name,IsNull(Salary,0000) 
from Instructor  
		
--6.Select Supervisor first name and the count of students who supervises on them
select sp.St_Fname ,count(s.St_Id) [number of student]
from  Student s,Student sp
where sp.St_Id=s.St_super
group by sp.St_Fname


--7.Display max and min salary for instructors
select max(Salary) maxsalary ,min(Salary) minsalary
from Instructor


--8.Select Average Salary for instructors 
select avg(salary)
from Instructor


--9.Display instructors who have salaries less than the average salary of all instructors.
SELECT *
FROM Instructor
WHERE salary < (SELECT AVG(salary) FROM Instructor);


--10.	Display the Department name that contains the instructor who receives the minimum salary
select D.Dept_Name
from Department D join Instructor Ins 
on  D.Dept_Id=Ins.Dept_Id
where Ins.Salary= (select Min(salary) from Instructor)

--======================================================================================--
--Part 02 // MyCompany 
--DQL
--1. For each project, list the project name and the total hours per week (for all employees) spent on that project.
select P.Pname,sum(W.Hours)
from Project P ,Works_for W
where P.Pnumber=W.Pno 
group by  P.Pname 


--2. For each department, retrieve the department name and the maximum, minimum and average salary of its employees.

select D.Dname,max(E.salary) Maxsalary,min(E.salary)Minsalary,AVG(E.salary)AvarageSalary
from Departments D,Employee E
where D.Dnum=E.Dno
group by D.Dname



--3. Retrieve a list of employees and the projects they are working on ordered by department and within each department, 
--ordered alphabetically by last name, first name.

 select *
from Employee e , Works_for wf , Project p
where e.SSN = wf.ESSn and p.Pnumber = wf.Pno
order by e.Dno , e.Fname ,e.Lname
 
 --4. Try to update all salaries of employees who work in Project �Al Rabwah� by 30% 	

update Employee
set Salary+=Salary*0.3
from Employee E ,Works_for W, Project p
where E.SSN=W.ESSn and W.Pno=p.Pnumber and P.Pname='Al Rabwah'

--DML
--1. In the department table insert a new department called "DEPT IT" , with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'.

insert into Departments
values ('DEPT IT',100,112233,'1-11-2006')


--2.	Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager) 

-- a.	First try to update her record in the department table
update Departments
set MGRSSN=968574
where DNum=100

--b.	Update your record to be department 20 manager.
insert into Employee (Fname,Lname,SSN)
values ('Mahmoud','Emad',102672)

update Departments
set MGRSSN=102672
where Dnum=20

Update Employee
set Dno=20
where SSN=102672

--c.Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)

insert into Employee (Fname,Lname,SSN)
values ('zaid','Emad',102660)

Update Employee
set Superssn=102672
where SSN= 102660


--3.	Unfortunately the company ended the contract with  Mr.Kamel Mohamed (SSN=223344) so try to delete him from your database in case you know that you will be temporarily in his position.
--Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handles these cases).

Update Employee
set Superssn=102672
where SSN=223344

Update Departments
set MGRSSN=102672
where MGRSSN=223344

Update Works_for
set ESSn=102672
where ESSn=223344

delete Dependent
where ESSN=223344

--======================================================================================--
--part 03 // My company
 --1.Retrieve the names of all employees in department 10 who work more than or equal 10 hours per week on the "AL Rabwah" project.
select E.Fname+' '+ E.Lname FullName
from Employee E,Works_for W,Project P
where E.SSN=W.ESSn and P.Pnumber=W.Pno and E.Dno=10 and W.Hours>=10  and P.Pname='AL Rabwah'

--2.Find the names of the employees who were directly supervised by Kamel Mohamed.
select E.Fname +' '+ E.Lname [Full Name]
from Employee E, Employee sup
where E.Superssn=sup.SSN and sup.Fname='Kamel' and sup.Lname='Mohamed'

 --3.Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name
select E.Fname+' '+ E.Lname FullName ,P.Pname
from Employee E,Works_for W,Project P
where E.SSN=W.ESSn and P.Pnumber=W.Pno
 order by P.Pname

 --4.For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.
select P.Pnumber ,D.Dname,E.Lname,E.Address,E.Bdate
from Departments D,Project P,Employee E
where D.Dnum=P.Dnum and E.SSN=D.MGRSSN and P.City='Cairo'

--5.Display the data of the department which has the smallest employee ID over all employees' ID.
select D.*
from Employee E,Departments D
where E.Dno=D.Dnum and E.SSN=(select min(SSN) from Employee)


--6.Display All Employees data and the data of their dependents even if they have no dependents.

select E.* ,D.*
from Employee E left outer join Dependent D
on E.SSN =D.ESSN
