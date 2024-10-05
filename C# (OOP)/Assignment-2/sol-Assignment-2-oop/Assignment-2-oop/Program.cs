namespace Assignment_2_oop
{
    internal class Program
    {
        static void Main()
        {
            Employee[] employees = new Employee[3];

            //employees[0] = new Employee()
            //{
            //    Id = 1,
            //    Name = "Mahmoud",
            //    Gender = Gender.M,
            //    Salary = 20000,
            //    Securitylevel = SecurityLevel.DBA,
            //    HiringDate = new HiringDate()
            //    {
            //        Day = 20,
            //        Month = 5,
            //        Year = 2023
            //    }
            //};

            //employees[1] = new Employee()
            //{
            //    Id = 2,
            //    Name = "zaid",
            //    Gender = Gender.M,
            //    Salary = 20000,
            //    Securitylevel = SecurityLevel.Developer,
            //    HiringDate = new HiringDate()
            //    {
            //        Day = 10,
            //        Month = 8,
            //        Year = 2024
            //    }
            //};


            //employees[2] = new Employee()
            //{
            //    Id = 3,
            //    Name = "Heba",
            //    Gender = Gender.F,
            //    Salary = 7000,
            //    Securitylevel = SecurityLevel.secretary,
            //    HiringDate = new HiringDate()
            //    {
            //        Day = 30,
            //        Month = 12,
            //        Year = 2020
            //    }
            //};

            Employee.InsertEmployeeData(employees);

            Employee.PrintEmpData(employees);
            Console.WriteLine("=====================");
            Employee.SortEmp(employees);
            Employee.PrintEmpData(employees);


        }
    }
}
