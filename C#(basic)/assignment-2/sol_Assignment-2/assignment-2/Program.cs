

using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment_2
{
    class program
    {
        public static void Main()
        {
            #region Q1
            //1.Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Enter a number: ");
            //int x = int.Parse(Console.ReadLine() ?? "0");

            //Console.WriteLine($"The number is: {x}"); 
            #endregion

            #region Q2
            ////2.Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //Console.Write("Enter your name: ");
            //string name=Console.ReadLine();
            //int x = Convert.ToInt32(name);
            //// can't convert because it is char not numeric value 
            #endregion

            #region Q3
            //3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float x = 3.5f, y = 4.5F;
            //Console.WriteLine($"Sum of x + y = {x + y}");
            #endregion

            #region Q4
            ////4.Write C# program that Extract a substring from a given string.
            //string word="Hello world";
            //string substrig = word.Substring(0, 5);// first is start index ,second number of char you want to take 
            // note if you write vlaue of start only the default of the second value it to the end of the string
            //Console.WriteLine(substrig); 
            #endregion

            #region Q5
            //5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int x = 10;
            //int y = x;
            //x = 500;
            //Console.WriteLine($"x={x} y={y}");
            // the value of x will be 500 and the value of the y still 10 
            #endregion

            #region Q6
            ////6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //int[] arr01 = { 1, 2, 3, 4 };
            //int[] arr02;
            //arr02=arr01;
            //arr02[1] = 100;
            //Console.WriteLine(arr01[1]);//100
            //Console.WriteLine(arr02[1]);//100 
            #endregion

            #region Q7
            ////7.Write C# program that take two string variables and print them as one variable 
            //string x=Console.ReadLine();
            //string y=Console.ReadLine();
            //Console.WriteLine($"{x}{y}"); 
            #endregion

            #region Q8
            ///*8.Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is 
            //Interest = (principal * rate * time) / 100.*/
            //double principal, rate, time;
            //principal= double.Parse(Console.ReadLine());
            //rate = double.Parse(Console.ReadLine());
            //time = double.Parse(Console.ReadLine());
            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine($"simple Interest: {interest}"); 
            #endregion

            #region Q9
            ////9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is
            ////BMI = (Weight) / (Height * Height)

            //double Weight = 70.0;
            //double Height = 1.90;

            //double BMI = Weight / (Height * Height);

            //Console.WriteLine($"BMI: {BMI}"); 
            #endregion

            #region Q10
            //  /*10-	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good.
            //* Assign the result in a variable then display the result.
            //* Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".*/
            //  int degree=int.Parse(Console.ReadLine());
            //  string ans = degree < 10 ? "Cold" : degree > 30 ? "Hot" : "Good";
            //  Console.WriteLine(ans); 
            #endregion

            #region Q11
            ///*
            // 11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex :
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001
            //*/
            //DateTime Currenttdate= DateTime.Now;
            //string format1 = $" Today’s date :{Currenttdate.Day},{Currenttdate.Month},{Currenttdate.Year}";
            //string format2 = $" Today’s date :{Currenttdate.Day}/{Currenttdate.Month}/{Currenttdate.Year}";
            //string format3 = $" Today’s date :{Currenttdate.Day}-{Currenttdate.Month}-{Currenttdate.Year}";
            //Console.WriteLine(format1);
            //Console.WriteLine(format2); 
            //Console.WriteLine(format3); 
            #endregion





        }
    }
}
