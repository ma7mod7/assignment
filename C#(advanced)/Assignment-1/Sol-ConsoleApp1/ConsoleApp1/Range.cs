using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region Q2

    //1.Create a generic class named Range<T> where T represents the type of values.
    internal class Range<T> where T : IComparable<T>

    {
        public T Max { get; set; }
        public T Min { get; set; }
        //2.Implement a constructor that takes the minimum and maximum values to define the range.
        public Range(T _min, T _max)
        {
            Max = _max; Min = _min;
        }

        public bool IsInRange(T item)
        {
            return item.CompareTo(Min) >= 0 && item.CompareTo(Max) <= 0;
        }

        //4.Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
        public T Length()
        {
            // To solve this error we will use dynamic to handle the data type in run-time
            //return Max-Min
            dynamic X = Max;
            dynamic Y = Min;
            return X - Y;
        }

    } 
    #endregion
}
