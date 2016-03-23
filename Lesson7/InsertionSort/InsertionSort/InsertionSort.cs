using System;

namespace SortApp
{
    class InsertionSort<T> : CommonMethods<T> where T : IComparable<T>
    {
        // Sort Array using Insertion Sort
        public override void Sorter(T[] myArray)
        {
            Console.WriteLine("Insertion sort:");
            for (int i = 1; i < myArray.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (myArray[j].CompareTo(myArray[j - 1]) < 0 )
                    {
                        SwapElements(ref myArray[j], ref myArray[j - 1]);
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
