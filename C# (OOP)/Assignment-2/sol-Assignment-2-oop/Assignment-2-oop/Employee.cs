using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop
{
    enum Gender
    {
        M=1,F=2
    }
    [Flags]
    enum SecurityLevel:byte
    {
        guest=1, Developer=2, secretary=4 , DBA=8
    }

    public class Employee:IComparable
    {
        int id;
        string? name;
        double salary;
        Gender gender;
        SecurityLevel securitylevel;
        HiringDate? hiringDate;

        public Employee()
        {
           
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value is not null ? value : "Ahmed"; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        internal Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public HiringDate HiringDate
        {
            get { return hiringDate; }
            set { hiringDate = value; }
        }
        internal SecurityLevel Securitylevel
        {
            get { return securitylevel; }
            set { securitylevel = value; }
        }
        public override string ToString()
        {
            return $"name:{name}\nSalary:{salary}\nGender:{gender}\nHiringDate:{hiringDate}\nSecuritylever:{securitylevel}\n";
        }
        public static void SortEmp(Employee[] employee)
        {
            if( employee is not null)
            {
                Array.Sort(employee);
                // sort by default call compareTo and i customized it to comparte based on hiring date
            }
        }
        public int CompareTo(object? obj)
        {
            Employee right = obj as Employee;
            if(hiringDate.Year > right.hiringDate.Year)
            {
                return -1;
            }
            else if (hiringDate.Year < right.hiringDate.Year)
            {
                return 1;
            }
            else
            {
                if(hiringDate.Month > right.hiringDate.Month)
                {
                    return -1;
                }
                else if (hiringDate.Month < right.hiringDate.Month)
                {
                    return 1;
                }
                else
                {
                    if (hiringDate.Day > right.hiringDate.Day)
                    {
                        return -1;
                    }
                    else if (hiringDate.Day < right.hiringDate.Day)
                    {
                        return 1;
                    }
                    else return 0;
                }
            }
        }

        public static void PrintEmpData(Employee[] emp)
        {
            if (emp is not null)
            {
                for (int i = 0; i < emp.Length; i++)
                {
                    Console.WriteLine($"Information for Employee data:{i+1}");
                    Console.WriteLine(emp[i]);
                }
            }
        }
        public static void InsertEmployeeData(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();
            }

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("Please eneter the employee data");
                bool flag;
                do
                {
                    Console.WriteLine("Please enter the ID ");
                    flag = int.TryParse(Console.ReadLine(), out employees[i].id);
                } while (!flag);

                do
                {
                    Console.WriteLine("Please enter the Name ");
                    employees[i].name = Console.ReadLine();

                } while (String.IsNullOrEmpty(employees[i].name));

                do
                {
                    Console.WriteLine("Please enter the Salary ");
                    flag = double.TryParse(Console.ReadLine(), out employees[i].salary);
                } while (!flag || employees[i].salary <= 0);

                int genderNum;
                Console.WriteLine("Please enter 1 for Male and 2 for Female :");
                do
                {
                    Console.WriteLine("Please enter the Gender ");
                    flag = int.TryParse(Console.ReadLine(), out genderNum);
                } while (!flag || !Enum.IsDefined(typeof(Gender), genderNum));
                employees[i].gender = (Gender)genderNum;

                Console.WriteLine("Please enter the Secuirty level ==> Guest = 1 , Developer = 2 , Secratry = 4 , DB = 8");
                int secuirtyprev;
                do
                {
                    Console.WriteLine("Please enter the SecuirtyPrivelege ");
                    flag = int.TryParse(Console.ReadLine(), out secuirtyprev);
                } while (!flag || !(secuirtyprev > 0 && secuirtyprev <= 15));
                employees[i].securitylevel = (SecurityLevel)secuirtyprev;

                Console.WriteLine("Please enter the hiring date that consist of Day , Month , Year :");
                int day, month, year;
                employees[i].hiringDate = new HiringDate();
                do
                {
                    Console.WriteLine("Please enter the day");
                    flag = int.TryParse(Console.ReadLine(), out day);
                } while (!flag);
                employees[i].hiringDate.Day = day;

                do
                {
                    Console.WriteLine("Please enter the month");
                    flag = int.TryParse(Console.ReadLine(), out month);
                } while (!flag);
                employees[i].hiringDate.Month = month;

                do
                {
                    Console.WriteLine("Please enter the year");
                    flag = int.TryParse(Console.ReadLine(), out year);
                } while (!flag);
                employees[i].hiringDate.Year = year;
            }
        }
    }
}
