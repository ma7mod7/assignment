using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;

namespace Assignment_4
{
    internal class Program
    {

        #region Q1
        // static void  swap1(int x,int y)
        // {
        //     int temp;
        //     temp = x;
        //     x = y;
        //     y = temp;

        // }

        //static void swap2(ref int x, ref int y)
        // {
        //     int temp;
        //     temp = x;
        //     x = y;
        //     y = temp;

        // } 
        #endregion

        #region Q2
        //static void func01(int[] arr)
        //{
        //    if (arr == null) return;
        //   // arr[0] = 100;
        //    arr = new int[] { 1000, 1333 };
        //}
        //static void func02(ref int[] arr)
        //{
        //    if (arr == null) return;
        //    //arr[0] = 100;
        //    arr = new int[] { 1000, 1333 };
        //}
        #endregion

        #region Q3
        //static void calc(int a, int b, out int sum, out int sub)
        //{
        //    sum = a + b;
        //    sub = a - b;
        //} 
        #endregion

        #region Q4
        //static int SumOfDigits(int num)
        //{
        //    int sum = 0;
        //    while (num > 0)
        //    {
        //        sum += num % 10;
        //        num /= 10;
        //    }
        //    return sum;
        //} 
        #endregion

        #region Q5
        //static bool IsPrime(int a)
        //{
        //    if (a == 1)
        //    {
        //        return false;
        //    }
        //    for (int i = 2; i < a; i++)
        //    {
        //        if (a % i == 0)
        //        {

        //            return false;
        //        }
        //    }
        //    return true;
        //} 
        #endregion

        #region Q6
        //static void MinMaxArray(ref int[] arr, out int min, out int max)
        //{
        //    //if (arr is null)
        //    //    return;

        //    max = arr[0];
        //    min = arr[0];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (max < arr[i])
        //            max = arr[i];
        //        else if (min > arr[i])
        //            min = arr[i];
        //    }
        //} 
        #endregion

        #region Q7
        //static int Factorial(int num)
        //{
        //    int sum = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        sum *= i;
        //    }
        //    return sum;
        //} 
        #endregion

        #region Q8
        //static string changchar(string s, int idx, char a)
        //{
        //    s = s.Remove(idx, 1);
        //    s = s.Insert(idx, a.ToString());
        //    return s;

        //} 
        #endregion
        static void Main()

        {
            #region Q1
            ////1-	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //int a =10,b=20;
            //swap1(a,b);
            //Console.WriteLine($"first number :{a}");
            //Console.WriteLine($"second number: {b}");
            //swap2(ref a,ref b);
            //Console.WriteLine($"first number :{a}");
            //Console.Write($"second number: {b}"); 
            #endregion

            #region Q2
            ////2-	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //int[] arr ={ 1,2,3,4};
            //func01(arr);
            //Console.WriteLine($"First element is :{arr[0]}");

            //func02(ref arr);
            //Console.WriteLine($"First element is :{arr[0]}"); 
            #endregion

            #region Q3
            ////3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int a = 10, b = 5;
            //int sumres,subres;
            //calc(a,b,out sumres,out subres);
            //Console.WriteLine($"Sum of two number is {sumres}");
            //Console.WriteLine($"subtracting of two number is {subres}"); 
            #endregion

            #region Q4
            ////4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //int num = 25,res;
            //res=SumOfDigits(num);
            //Console.WriteLine($"Sum of Digits is :{res}"); 
            #endregion

            #region Q5
            ////5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //int num;

            //Console.Write("Enter number to check if is is pime or not: ");
            //num=int.Parse(Console.ReadLine());
            //if (IsPrime(num) == true) Console.WriteLine("Prime");
            //else Console.WriteLine("Is not prime"); 
            #endregion

            #region Q6
            ////6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int size,min,max;
            //Console.WriteLine("Enter Array size: ");
            //int.TryParse(Console.ReadLine(), out size);
            //int[] arr=new int[size];   
            //for (int i = 0;i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine() , out arr[i]);
            //}
            //MinMaxArray(ref arr, out min, out max);
            //Console.WriteLine($"Max value: {max}");
            //Console.WriteLine($"Max value: {min}"); 
            #endregion

            #region Q7
            ////7 - Create an iterative(non-recursive) function to calculate the factorial of the number specified as parameter
            //int num;
            //Console.WriteLine("Enter Number: ");
            //int.TryParse(Console.ReadLine(), out num);
            //Console.WriteLine($"Fatorial of number {num} = :{Factorial(num)}"); 
            #endregion

            #region Q8
            //8-	Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //Console.WriteLine("Enter string:");
            //string word=Console.ReadLine();

            //Console.WriteLine("Enter index:");
            //int idx =int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter char: ");
            //char a = char.Parse(Console.ReadLine());
            //Console.WriteLine($"String after change:{changchar(word,idx,a)}"); 
            #endregion
        }

    }
}
