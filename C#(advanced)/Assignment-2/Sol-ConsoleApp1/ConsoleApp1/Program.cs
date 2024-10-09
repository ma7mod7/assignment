using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        #region Q1
        //public static int search(List<int> list, int val)
        //{
        //    int cnt = 0;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i] > val) cnt++;
        //    }
        //    return cnt;

        //} 
        #endregion

        #region Q3
        //public static void rev(Queue<int> q)
        //{
        //    Stack<int> st = new Stack<int>(q.Count);
        //    while (q.Count > 0) { 
        //        st.Push(q.Dequeue());
        //    }
        //    while (st.Count > 0)
        //    {
        //        q.Enqueue(st.Pop());
        //    }

        //} 
        #endregion

        #region Q5
        //public static  int[] Remove(ref int[] nums)
        //{

        //    Array.Sort(nums);
        //    int[] temp = new int[nums.Length];
        //    int cnt = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (i==0||nums[i] != nums[i - 1])
        //        {
        //            temp[cnt++] = nums[i];
        //        }
        //    }
        //    int[] res = new int[cnt];
        //    Array.Copy(temp, res, cnt);
        //    return res;
        //} 

        //public static void Removev02<T>(ref T[] nums)
        //{
        //    HashSet<T> set = new HashSet<T>();  
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        set.Add(nums[i]);
        //    }
        //    nums=set.ToArray();
        //}
        #endregion

        #region Q6
        //public static void RemoveOdd(ArrayList nums)
        //{

        //    for (int i = 0; i < nums.Count; i++)
        //    {
        //        if ((int)nums[i] % 2 != 0) { 
        //                nums.RemoveAt(i);
        //        }
        //    }

        //} 
        #endregion

        #region Q8
        //public static int Series(Stack<int> stack, int target)
        //{
        //    int cnt = 0;
        //    bool flag = false;
        //    while(stack.Count>0)
        //    {

        //        if (stack.Peek() == target)
        //        {
        //            flag=true;
        //            break;
        //        }
        //        else cnt++;
        //        stack.Pop();
        //    }
        //    return flag? cnt : 0;

        //} 
        #endregion

        #region Q9
        //public static int[] Intersection(int[] arr1, int[] arr2)
        //{
        //    Dictionary<int, int> map = new Dictionary<int, int>();
        //    foreach (int i in arr1)
        //    {
        //        if (map.ContainsKey(i)) map[i]++;
        //        else
        //            map[i] = 1;
        //    }
        //    List<int> list = new List<int>();
        //    foreach (int i in arr2)
        //    {
        //        if (map.ContainsKey(i) && map[i] > 0)
        //        {
        //            list.Add(i);
        //            map[i]--;
        //        }
        //    }
        //    return list.ToArray();

        //}
        //static int[] IntersectV02(int[] nums1, int[] nums2)
        //{
        //    Array.Sort(nums1);
        //    Array.Sort(nums2);

        //    List<int> list = new List<int>();

        //    int X = 0, Y = 0;

        //    while (X < nums1.Length && Y < nums2.Length)
        //    {
        //        if (nums1[X] < nums2[Y])
        //            X++;
        //        else if (nums1[X] > nums2[Y])
        //            Y++;
        //        else
        //        {
        //            list.Add(nums1[X]);
        //            X++;
        //            Y++;
        //        }
        //    }

        //    return list.ToArray();
        //} 
        #endregion

        #region Q10
        //public static ArrayList FindSubArr(ArrayList arr, int targtetsum)
        //{
        //    ArrayList Res = new ArrayList();
        //    int sum = 0;
        //    int left = 0;
        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        sum += (int)arr[i];
        //        while (sum > targtetsum && left <= i)
        //        {
        //            sum -= (int)arr[left];
        //            left++;
        //        }
        //        if (sum == targtetsum)
        //        {
        //            Res = new ArrayList(arr.GetRange(left, i - left + 1) );
        //            break;
        //        }
        //    }
        //    return Res;

        //} 
        #endregion

        #region Q11
        //public static Queue<int> rev(Queue<int> q, int k)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    for (int i = 0; i < k; i++)
        //    {
        //        stack.Push(q.Dequeue());
        //    }
        //    Queue<int> q2 = new Queue<int>();
        //    while (stack.Count > 0)
        //    {
        //        q2.Enqueue(stack.Pop());
        //    }
        //    while (q.Count > 0)
        //    {
        //        q2.Enqueue(q.Dequeue());
        //    }
        //    return q2;
        //} 
        #endregion


        static void Main(string[] args)
        {

            #region Q1
            //string[] input = Console.ReadLine().Split(' '); // Split input by space
            //int size = int.Parse(input[0]); // First value
            //int q = int.Parse(input[1]);

            ////int size;
            ////int.TryParse(Console.ReadLine(),out size);
            ////int q;
            ////int.TryParse(Console.ReadLine(),out q);
            //List<int> list = new List<int>(size);
            //list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            ////for (int i = 0; i < size; i++)
            ////{
            ////    int num;
            ////    int.TryParse(Console.ReadLine(),out num);
            ////    list.Add(num);

            ////}


            //for (int i = 0;i < q; i++)
            //{
            //    int num;
            //    int.TryParse(Console.ReadLine() ,out num);
            //    Console.WriteLine(search(list, num)); 

            //} 
            #endregion

            #region Q2
            //int size;
            //bool flag = true;
            //do
            //{
            //    Console.WriteLine("Enter the size of the array");

            //} while (!int.TryParse(Console.ReadLine(), out size));
            //List<int> list = new List<int>(size);
            //list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //int j = size - 1;
            //for (int i = 0; i < list.Count / 2; i++)
            //{

            //    if (list[i] != list[j])
            //    {
            //        flag = false;
            //        break;

            //    }
            //    else j--;
            //}
            //if (flag) Console.WriteLine("Yes");
            //else Console.WriteLine("No"); 
            #endregion

            #region Q3
            //Queue<int> q = new Queue<int>(4);
            //q.Enqueue(5);
            //q.Enqueue(6);
            //q.Enqueue(7);
            //q.Enqueue(8);
            //rev(q);
            //foreach (int x in q) Console.Write($"{x} "); 
            #endregion

            #region Q4
            //string x=Console.ReadLine();
            //Stack<char> stack = new Stack<char>(x.Length);
            //for (int i = 0; i < x.Length; i++)
            //{
            //    if (x[i] == '[' || x[i] == '{' || x[i] == '(') stack.Push(x[i]);
            //    else if (x[i] == ']' && stack.Count > 0) stack.Pop();
            //    else if (x[i] == '}' && stack.Count > 0) stack.Pop();
            //    else if (x[i] ==')' && stack.Count>0)stack.Pop();
            //    else stack.Push(x[i]);  
            //}
            //if (stack.Count > 0) Console.WriteLine("Not Balanced");
            //else Console.WriteLine("Balanced"); 
            #endregion

            #region Q5
            //int[] nums = { 1, 1, 2, 3, 3 };

            ////int[] res = Remove(ref nums);
            //Removev02<int>(ref nums);
            //foreach (int i in nums) Console.WriteLine(i);
            #endregion

            #region Q6
            //ArrayList res=new ArrayList() ;
            //int size;
            //do
            //{
            //    Console.WriteLine("Enter Size of the array");

            //} while (!int.TryParse(Console.ReadLine(), out size));

            //int element;
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter Element of the array {i+1}:");

            //    } while (!int.TryParse(Console.ReadLine(), out element));
            //    res.Add(element);   

            //}

            //RemoveOdd(res);
            //for (int i = 0;i<res.Count;i++) Console.Write($"{res[i]} "); 
            #endregion

            #region Q7
            //int size;
            //do
            //{
            //    Console.WriteLine("Enter Size of the array");

            //} while (!int.TryParse(Console.ReadLine(), out size));
            //Queue<object> queue = new Queue<object>();
            //object element;
            //for (int i = 0; i < size; i++) {
            //    do
            //    {
            //        Console.WriteLine($"Element {i + 1} ");
            //        element = Console.ReadLine(); ;

            //    } while (string.IsNullOrEmpty((string)element));
            //    queue.Enqueue(element);
            //}
            //foreach(object i in queue) Console.WriteLine(i); 
            #endregion

            #region Q8
            // Stack<int> st = new Stack<int>();
            // st.Push(1);
            // st.Push(2);
            // st.Push(3);
            // st.Push(4);
            // st.Push(5);
            // st.Push(6);

            // int traget;
            // do
            // {
            //     Console.Write("Enter the target: ");

            // }
            // while (!int.TryParse(Console.ReadLine(), out traget));
            //int res= Series(st, traget);
            // if (res == 0) Console.WriteLine("Target was not found");
            // else Console.WriteLine($"Target was found successfully and the count {res}"); 
            #endregion

            #region Q9
            //int size01;
            //do
            //{
            //    Console.Write("Enter size of first array:");
            //} while (!int.TryParse(Console.ReadLine(), out size01) && size01 <= 0);

            //int[] arr01 = new int[size01];
            //for (int i = 0; i < arr01.Length; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter Element of 1st Array: ");
            //    } while (!int.TryParse(Console.ReadLine(), out arr01[i]));
            //}

            //int size02;
            //do
            //{
            //    Console.Write("Enter size of Second array:");
            //} while (!int.TryParse(Console.ReadLine(), out size02) && size02 <= 0);

            //int[] arr02 = new int[size01];
            //for (int i = 0; i < arr02.Length; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter Element of 2st Array: ");

            //    } while (!int.TryParse(Console.ReadLine(), out arr02[i]));
            //}

            //int[] res = Intersection(arr01, arr02);
            //Console.WriteLine("The intersectioin:");
            //foreach (int i in res) Console.Write(i); 
            #endregion

            #region Q10
            //int target;
            //int size01;
            //do
            //{
            //    Console.Write("Enter size of array:");
            //} while (!int.TryParse(Console.ReadLine(), out size01) && size01 <= 0);
            //ArrayList array = new ArrayList(size01);

            //int element;
            //for (int i = 0; i < size01; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter Element Array:{i+1} ");
            //    } while (!int.TryParse(Console.ReadLine(), out element));
            //    array.Add(element);
            //}

            //do
            //{
            //    Console.Write("Enter The Target sum:");
            //} while (!int.TryParse(Console.ReadLine(), out target));

            //Console.WriteLine("Sub Array is: ");
            //ArrayList array2 = FindSubArr(array,target);
            //foreach (int i in array2) Console.Write($"{i } "); 
            #endregion

            #region Q11
            //Queue<int> q = new Queue<int>();
            //q.Enqueue(1);
            //q.Enqueue(2);
            //q.Enqueue(3);              
            //q.Enqueue(4);
            //q.Enqueue(5);

            //int k=int.Parse(Console.ReadLine());
            //Queue<int>res=rev(q, k);   
            //foreach (int i in res) Console.Write($"{i} "); 
            #endregion


        }
    }

}
