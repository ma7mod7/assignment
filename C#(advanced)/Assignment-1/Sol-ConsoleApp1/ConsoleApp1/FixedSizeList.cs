using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FixedSizeList<T>:IEnumerable<T>
    {
        #region Q5
        /*
        5.	implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
           Requirements:
           1.	Create a generic class named FixedSizeList<T>.
           2.	Implement a constructor that takes the fixed capacity of the list as a parameter.
           3.	Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
           4.	Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.
       */
        public int Capacity { get; set; }
        public List<T> List { get; set; }
        public FixedSizeList(int _size)
        {
            Capacity = _size;
            List = new List<T>(Capacity);
        }

        public void AddItem(T item)
        {
            if (List.Count() >= Capacity)
                throw new InvalidOperationException("List Has Reached it's Max Capacity");

            else
                List.Add(item);

        }
        public T GetValue(int idx)
        {
            if (idx >= Capacity || idx < 0) throw new InvalidOperationException("Invalied index");
            else
                return List[idx];

        }

        public IEnumerator<T> GetEnumerator()
        {
            return List.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

    }
}
