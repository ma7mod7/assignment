using System.ComponentModel;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_3
{
    class Program
    {
        static void Main()
        {
            #region Q1
            //1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.Write("Enter any Number:");
            //int.TryParse(Console.ReadLine(), out int num);
            //if (num % 3 == 0 && num % 4 == 0)
            //    Console.WriteLine("YES");

            //else
            //    Console.WriteLine("NO");
            #endregion

            #region Q2
            ////2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("Enter an Integer Number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //if (num < 0) Console.WriteLine("negitive");
            //else Console.WriteLine("Positive"); 
            #endregion

            #region Q3
            ////3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.Write("Enter 3 Number");
            //int[] Arr = new int[3];
            //Console.WriteLine();
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.Write($"Enter element {i + 1} : ");
            //   Arr[i]=int.Parse(Console.ReadLine()??"N");
            //}
            //Console.Write( $"Max Element: {Arr.Max()}");
            //Console.WriteLine();
            //Console.Write($"Min Element: {Arr.Min()}"); 
            #endregion

            #region Q4
            //    //4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //    Console.Write("Enter Any number: ");
            //    int.TryParse(Console.ReadLine(), out int value);
            //    if (value % 2 == 0) Console.WriteLine("Number is even");
            //    else Console.WriteLine("Number is odd");
            //
            #endregion

            #region Q5
            ////  5 - Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            //Console.Write("Enter any char: ");
            //char.TryParse(Console.ReadLine(), out char check);
            //if (check == 'a' || check == 'e' || check == 'i' || check == 'o' || check == 'u') Console.WriteLine("Vowel");
            //else Console.WriteLine("Consonant"); 
            #endregion

            #region Q6
            ////6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("Enter Number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write($"{i + 1} ");
            //} 
            #endregion

            #region Q7
            ////7- Write a program that allows the user to insert an integer then  print a multiplication table up to 12.
            //Console.Write("Enter Number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //int sum = num;
            //Console.WriteLine(num);

            //for (int i = 0; i < 11; i++)

            //{
            //    Console.Write($"{sum += num} ");
            //} 
            #endregion

            #region Q8
            //// 8 - Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine("Enter Number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 1; i <= num; i++) {
            //    if (i % 2 == 0) Console.WriteLine(i);
            //} 
            #endregion

            #region Q9
            ////  9 - Write a program that takes two integers then prints the power.
            //Console.WriteLine("Enter Two Number: ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //int.TryParse(Console.ReadLine(), out int num2);
            //Console.WriteLine(Math.Pow(num1, num2)); 
            #endregion

            #region Q10
            //10- Write a program to enter marks of five subjects and calculate total, average and percentage
            //int[] arr01 = new int[5];
            //int sum = 0;
            //for (int i = 0; i < arr01.Length; i++)
            //{
            //    Console.WriteLine($"Enter Mark number {i + 1}: ");
            //    arr01[i] = int.Parse(Console.ReadLine());
            //    sum += arr01[i];

            //}

            //Console.WriteLine($"Sum:{sum}");
            //Console.WriteLine($"Avg{sum / 5}"); 
            #endregion

            #region Q11
            ////11- Write a program to input the month number and print the number of days in that month.
            //int number;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter month number: ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag);
            //switch (number)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine($"Number of Days in month {number} = 31");
            //        break;

            //    case 2:
            //        Console.WriteLine($"Number of day in month {number} = 28");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine($"Number of Days in month {number} = 30");
            //        break;

            //    default:
            //    Console.WriteLine("Invalid input");
            //     break;
            //} 
            #endregion

            #region Q12
            //int num1, num2;

            //char oprator;
            //bool flag01, flag02, flag03;
            //do
            //{
            //    Console.WriteLine("Enter First Num: ");
            //    flag01 = int.TryParse(Console.ReadLine(), out num1);

            //    Console.WriteLine("Enter the opreation that you want to know (+ | - | * | /)");
            //    flag02 = char.TryParse(Console.ReadLine(), out oprator);

            //    Console.WriteLine("Enter Second Num: ");
            //    flag03 = int.TryParse(Console.ReadLine(), out num2);


            //} while (!(flag01 && flag02 && flag03));

            //switch (oprator)
            //{
            //    case '+':
            //        Console.WriteLine($"{num1} + {num2}= {num1 + num2}");
            //        break;

            //    case '-':
            //        Console.WriteLine($"{num1} - {num2}= {num1 - num2}");
            //        break;

            //    case '*':
            //        Console.WriteLine($"{num1} * {num2}= {num1 * num2}");
            //        break;
            //    case '/':
            //        if (num2 == 0)
            //        {
            //             Console.WriteLine("Can't Divide by zero");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{num1} / {num2}= {num1 / num2}");
            //            break;
            //        }
            //    default:
            //        Console.WriteLine("Nonvalied  oprator");
            //        break;
            //} 
            #endregion

            #region Q13
            //13- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter word:");
            //string word;
            //word = Console.ReadLine()??"null";
            //for (int i = word.Length-1; i >=0; i--)
            //{
            //    Console.Write(word[i]);
            //} 
            #endregion

            #region Q14
            ////14- Write a program to allow the user to enter int and print the REVERSED of it.
            //int num,newnum=0,reminder=0;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter number: ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //} while (!flag);
            //while (num>0)
            //{
            //    reminder = num % 10;
            //    newnum = (newnum * 10) + reminder;
            //    num /= 10;

            //}
            //Console.WriteLine(newnum); 
            #endregion

            #region Q15
            //15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //int num01, num02;
            //bool flag1, flag2;
            //do
            //{
            //    Console.WriteLine("Enter First number: ");
            //    flag1 = int.TryParse(Console.ReadLine(), out num01);

            //    Console.WriteLine("Enter Second number: ");
            //    flag2 = int.TryParse(Console.ReadLine(), out num02);

            //} while (!(flag1 && flag2));
            //int cnt = 0;
            //for (int i = num01; i < num02; i++)
            //{
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            cnt++;
            //            break;
            //        }
            //    }
            //    if (cnt == 0 && i!=1) Console.WriteLine($"{i}");
            //    cnt = 0;
            //} 
            #endregion

            #region Q16
            // //16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            // int num, dn, binary = 0, j;
            // Console.WriteLine("Enter Number ");
            // num = int.Parse(Console.ReadLine());

            // dn = num;
            // j = 1;

            //while(num>0)
            // {
            //     binary = binary + (num % 2) * j;
            //     j = j * 10;
            //     num = num / 2;
            // }
            // Console.WriteLine($"binary of {dn} = {binary}"); 
            #endregion

            #region Q17
            ////17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //int x1,y1,x2,y2,x3,y3;
            //bool flag1, flag2, flag3,flag4,flag5,flag6;
            //do
            //{
            //    Console.WriteLine("Enter first point: ");
            //    flag1=int.TryParse(Console.ReadLine(), out x1);
            //    flag2=int.TryParse(Console.ReadLine(), out y1);

            //    Console.WriteLine("Enter second point: ");
            //    flag3 = int.TryParse(Console.ReadLine(), out x2);
            //    flag4 = int.TryParse(Console.ReadLine(), out y2);

            //    Console.WriteLine("Enter third point: ");
            //    flag5= int.TryParse(Console.ReadLine(), out x3);
            //    flag6 = int.TryParse(Console.ReadLine(), out y3);
            //}while(!(flag1 || flag2||flag3||flag4||flag6));
            //if ((x1 == 0 && x2 == 0 && x3 == 0) || (y1 == 0 && y2 == 0 && y3 == 0) || (x1 == y1 && x2 == y2 && x3 == y3))
            //{
            //    Console.WriteLine("This lie on a single straight line");
            //}
            //else
            //    Console.WriteLine("This dosen't lie on a single straight line");
            /* antoher code on this Q */
            //int x1, y1, x2, y2, x3, y3;
            //bool flag1, flag2, flag3, flag4, flag5, flag6;
            //int slope1, slope2, slope3;

            //do
            //{
            //    Console.WriteLine("Enter first point: ");
            //    flag1 = int.TryParse(Console.ReadLine(), out x1);
            //    flag2 = int.TryParse(Console.ReadLine(), out y1);

            //    Console.WriteLine("Enter second point: ");
            //    flag3 = int.TryParse(Console.ReadLine(), out x2);
            //    flag4 = int.TryParse(Console.ReadLine(), out y2);

            //    Console.WriteLine("Enter third point: ");
            //    flag5 = int.TryParse(Console.ReadLine(), out x3);
            //    flag6 = int.TryParse(Console.ReadLine(), out y3);
            //} while (!(flag1 || flag2 || flag3 || flag4 || flag6));
            //slope1 = y2 - y1 / x2 - x1;
            //slope2=y3 - y2 / x3 - x2; ;
            //slope3=y3-y1 / x3 - x1;
            //if (slope1==slope2 && slope2==slope3)
            //{
            //    Console.WriteLine("This lie on a single straight line");
            //}
            //else
            //    Console.WriteLine("This dosen't lie on a single straight line"); 
            #endregion

            #region Q18
            //int hours;
            //Console.WriteLine("Enter the number of hourse you take to finish");
            //int.TryParse(Console.ReadLine(), out hours);
            //if (hours >= 2 && hours <= 3)
            //    Console.WriteLine("highly efficient");
            //else if (hours>=4 && hours <= 5) Console.WriteLine("training to enhance their speed.");
            //else Console.WriteLine("leave the company. "); 
            #endregion

            #region Q19

            ////19-Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //// 100
            //// 010
            //// 001

            //int n;
            //Console.WriteLine("Enter size of matrix");
            //int.TryParse(Console.ReadLine(), out n);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)

            //    {
            //        if (i == j) Console.Write("1");
            //        else
            //        Console.Write("0");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q20
            //// 20 - Write a program in C# Sharp to find the sum of all elements of the array.
            //int size,sum=0;
            //Console.Write("Enter the size of Array: ");
            //int.TryParse(Console.ReadLine(), out size);
            //int[]Arr=new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter the values {i+1}: ");
            //    int.TryParse(Console.ReadLine() , out Arr[i] );
            //    sum += Arr[i];
            //}
            //Console.WriteLine($"Sum of the array is : {sum}"); 
            #endregion

            #region Q21
            ////21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int size, sum = 0;
            //Console.Write("Enter the size of Array: ");
            //int.TryParse(Console.ReadLine(), out size);
            //int[] Arr = new int[size],Arr02 = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter the values of first Array: #{i + 1}: ");
            //    int.TryParse(Console.ReadLine(), out Arr[i]);

            //}
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter the values of second Array: #{i + 1}: ");
            //    int.TryParse(Console.ReadLine(), out Arr02[i]);

            //}
            //int newsize=2*size;
            //int[] Arr03 = new int[newsize];
            //int x=0;
            //for ( x=0 ; x < size; x++)
            //{
            //    Arr03[x] = Arr[x];
            //}

            //for(int i = 0; i <size; i++)
            //{
            //    Arr03[x]=Arr02[i];
            //    x++;
            //}

            //Array.Sort(Arr03);
            //for (int i = 0;i<Arr03.Length;i++) Console.Write($"{Arr03[i]} "); 
            #endregion

            #region Q22
            ////22- Write a program in C# Sharp to count the frequency of each element of an array.
            //int size, sum = 0;
            //Console.Write("Enter the size of Array: ");
            //int.TryParse(Console.ReadLine(), out size);
            //int[] arr = new int[size];
            //int[] freq = new int[10005] ;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter the values of first Array: #{i + 1}: ");
            //       int.TryParse(Console.ReadLine(), out arr[i]);
            //    freq[arr[i]]++;
            //}
            //for (int i = 0;i < freq.Length; i++)
            //{
            //    if (freq[i] > 0)
            //    {
            //        Console.WriteLine($"{i}: {freq[i]} ");
            //    }
            //} 
            #endregion

            #region Q23
            ////23- Write a program in C# Sharp to find maximum and minimum element in an array
            //int size, sum = 0;
            //Console.Write("Enter the size of Array: ");
            //int.TryParse(Console.ReadLine(), out size);
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter the values of first Array: #{i + 1}: ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //Console.WriteLine($"{arr.Max()}") ;
            //Console.WriteLine($"{arr.Min()}"); 
            #endregion

            #region Q24
            ////24 - Write a program in C# Sharp to find the second largest element in an array.
            //int size, sum = 0;
            //Console.Write("Enter the size of Array: ");
            //int.TryParse(Console.ReadLine(), out size);
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter the values of first Array: #{i + 1}: ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}

            //int large =arr.Max();
            //int large2=-1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if(arr[i] < large && arr[i]>large2)
            //        large2 = arr[i];
            //}

            //Console.WriteLine($"Largest elemnt: {large}");
            //Console.WriteLine($"Second Largest elemnt: {large2}"); 
            #endregion

            #region Q25
            ////25-. Consider an Array of Integer values with size N, having values as    in this Example
            //int size, distance = 0,ans=0;
            //Console.Write("Enter the size of Array: ");
            //int.TryParse(Console.ReadLine(), out size);
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter the values of first Array: #{i + 1}: ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if(arr[i] == arr[j])
            //        {
            //            distance = j - i;
            //        }
            //        if (distance > ans) ans = distance - 1;
            //    }
            //}
            //Console.WriteLine(ans); 
            #endregion

            #region Q26
            ////26- Given a list of space separated words, reverse the order of the words.
            //Console.WriteLine("Enter Sentence: ");
            //string sen = Console.ReadLine();

            //string result = "";

            //string[] str = sen.Split(" ");

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    result += str[i] + " ";
            //}

            //Console.WriteLine(result); 
            #endregion

            #region Q27
            ////27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //int[,] arr1 = new int[3, 3];
            //int[,] arr2 = new int[3, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("Enter Values ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}
            //for(int i = 0;i< 3; i++)
            //{
            //    for(int j = 0;j < 3; j++)
            //    {
            //        Console.WriteLine($"{arr2[i,j]}");
            //    }
            //} 
            #endregion

            #region Q28
            ////28- Write a Program to Print One Dimensional Array in Reverse Order
            //int[] arr = { 1, 2, 3, 4, 5 };

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine($"{arr[i]}");
            //} 
            #endregion

        }
    }
}
