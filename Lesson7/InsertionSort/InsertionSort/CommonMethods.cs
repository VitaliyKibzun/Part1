using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp
{
    abstract class CommonMethods<T> : ISorter<T> where T : IComparable<T>
    {
        // Define myArray Property.
        private T[] myArray;

        public T[] MyArray
        {
            get {return myArray;}
            set { if (value != null) myArray = value; }
        }
        

        // Show Array
        public void ShowArray()
        {
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write("{0}  ", MyArray[i]);
            }
        }

        // Swap Elements
        public void SwapElements(ref T firstElement, ref T secondElement)
        {
            T tmp = firstElement;
            firstElement = secondElement;
            secondElement = tmp;
        }

        // Call relevant Sort method
        public abstract void Sorter(T[] MyArray);
    }
}
