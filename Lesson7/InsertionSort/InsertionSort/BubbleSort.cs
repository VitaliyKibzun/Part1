using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp
{
    class BubbleSort<T> : CommonMethods<T> where T : IComparable<T>
    {
        // Sort Array using Bubble Sort
        public override void Sorter(T[] myArray)
        {
            Console.WriteLine("Bubble Sort:");
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length - i - 1; j++)
                {
                    if (myArray[j].CompareTo(myArray[j + 1]) > 0)
                    {
                        SwapElements(ref myArray[j], ref myArray[j + 1]);
                    }
                    Console.Write("Internal steps of Sorting myArray = ");
                    ShowArray();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
