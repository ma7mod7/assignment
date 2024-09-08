using System.ComponentModel;
using System.Drawing;
using System.Threading;

namespace Assignment_1
{
    internal class Program
    {
        #region Q1
        //enum WeekDays
        //{
        //    Monday, Tuesday, Wednesday,Thursday ,Friday, Saturday,Sunday
        //} 
        #endregion

        #region Q2
        //2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
        public struct Person
        {
            string? name;
            int age;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public Person(string _name, int _age)
            {
                name = _name;
                age = _age;
            }
            public override string ToString()
            {
                return $"Name:{name} =>Age:{age}";
            }
        }

        #endregion

        #region Q3
        ////3.	Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
        //enum SeasOn
        //{
        //    Spring, Summer, Autumn, Winter
        //} 
        #endregion

        #region Q4
        ////1.	Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
        ////Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
        //[Flags]
        //enum Permissions
        //{
        //    Read=1, write2, Delete=4, Execute=8
        //} 
        #endregion

        #region Q5
        ////5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
        //enum Color
        //{
        //    Red, Green, Blue
        //} 
        #endregion

        #region Q6
        ////6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
        //public struct Point
        //{
        //    private double x;
        //    private double y;
        //    public Point(double x, double y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }
        //    public double X
        //    {
        //        get { return x; }
        //        set { x = value; }
        //    }
        //    public double Y
        //    {
        //        get { return y; }
        //        set { y = value; }
        //    }
        //    public override string ToString() => $"X:{x},Y:{y}";

        //}
        //static Point CreatePoint()
        //{
        //    Point p = new Point();
        //    Console.WriteLine("Enter X:");
        //    bool flag;
        //    do
        //    {
        //        flag = double.TryParse(Console.ReadLine(), out double val);
        //        if(flag)p.X = val;
        //        else Console.Write("Invalid Input");
        //    } while (!flag);


        //    Console.Write("Enter Y:");
        //    bool flag2;
        //    do
        //    {
        //        flag2 = double.TryParse(Console.ReadLine(), out double val);
        //        if (flag2) p.Y = val;
        //        else Console.WriteLine("Invalid Input");
        //    } while (!flag2);

        //    return p;
        //}
        //static double Calc(Point p1,Point p2)
        //{
        //    return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        //} 
        #endregion


        static void Main()
        {
            #region Q1
            ////1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            ////The Enum.GetValues() method in C# returns an array of all the values in a given enumeration 
            //foreach (var item in Enum.GetValues(typeof(WeekDays))) {
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q2
            //Person[] persons = {
            //    new Person("Ahmed",30) ,
            //    new Person("alaa",18),
            //    new Person("mahmoud",20)
            //};
            //foreach (var p in persons)
            //{
            //    Console.WriteLine(p.ToString());
            //} 
            #endregion

            #region Q3
            //Console.WriteLine("Enter Season Name: ");
            ////string NameOfSeason=Console.ReadLine();
            //SeasOn se;
            //if (Enum.TryParse<SeasOn>(Console.ReadLine(), true, out se))
            //{
            //    if (se == SeasOn.Spring)

            //        Console.WriteLine("march to may ");

            //    else if (se == SeasOn.Autumn)

            //        Console.WriteLine("September to November");

            //    else if (se == SeasOn.Winter)

            //        Console.WriteLine("December to February");

            //    else if (se == SeasOn.Summer)


            //        Console.WriteLine("june to august ");
            //}
            //else Console.WriteLine("Not valied"); 
            #endregion

            #region Q4
            //Permissions per=Permissions.Read;
            //Console.WriteLine(per);

            ////Add
            //per|=Permissions.Execute;
            //Console.WriteLine(per);


            ////Remove 
            //per ^= Permissions.Execute;
            //Console.WriteLine(per);

            //if((per & Permissions.Read) == Permissions.Read) Console.WriteLine("Permission Found");
            //else Console.WriteLine("Not found"); 
            #endregion

            #region Q5
            //Console.WriteLine("Enter Color:");
            //string input=Console.ReadLine();
            //Color color;

            //if (Enum.TryParse(input,out color)) Console.WriteLine("Not Primary");
            //else Console.WriteLine("Primary Color"); 
            #endregion

            #region Q6
            //Point p1 =new Point();
            //Console.WriteLine("Enter 1st Point: ");
            //p1= CreatePoint();

            //Point p2 = new Point();
            //Console.WriteLine("Enter 2st Point: ");
            //p2 = CreatePoint();
            //Console.WriteLine($"Distinces = {Calc(p1,p2)}"); 
            #endregion

            #region Q7
            //Person[] persons = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    string name;

            //    do
            //    {
            //        Console.WriteLine($"Enter the name for person number {i + 1}:");
            //        name = Console.ReadLine();
            //    } while (string.IsNullOrWhiteSpace(name));
            //    persons[i].Name = name;
            //    int age;
            //    bool valid;

            //    do
            //    {
            //        Console.WriteLine($"Enter the age for person number {i + 1}:");
            //        valid = int.TryParse(Console.ReadLine(), out age);
            //    } while (!valid);
            //    persons[i].Age = age;


            //}
            //Person old = persons[0];
            //for (int i = 0; i < 3; i++)
            //{

            //    if (old.Age < persons[i].Age)
            //    {
            //        old = persons[i];
            //    }

            //}
            //Console.WriteLine($"The oldes Person is {old.Name}=> Age {old.Age}"); 
            #endregion


        }
    }
}
