using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Helper
    {
        #region Q3
        //3.You are given an ArrayList containing a sequence of elements.
        //try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse.
        //Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
        public static void ReverseArr(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;
            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++;
                right--;
            }
        }


        #endregion

        #region Q4
        public static List<int> Even(List<int> list)
        {
            List<int> array = new List<int>();
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i] % 2 == 0)
                {
                    array.Add(list[i]);
                }
            }
            return array;
        }
        #endregion

        #region Q6
        //6.Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1. Hint you can use dictionary
        public static int FindFirstIdx(string input)
        {
            Dictionary<char, int> res = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (res.ContainsKey(c)) res[c]++;
                else res[c] = 1;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (res[input[i]] == 1) return i;
            }
            return -1;
        } 
        #endregion

    }
}
