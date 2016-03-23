using System;

namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {

            CommonMethods<int> commonMethodsInt = new BubbleSort<int>();

            // Create MyArray
            commonMethodsInt.MyArray = new int[4] { 4, 3, 2, 1 };
            
            // Show unsorted MyArray
            Console.Write("Unsorted myArray = ");
            commonMethodsInt.ShowArray();
            Console.WriteLine();
            Console.WriteLine();

            // Sort MyArray using Bubble Sort
            commonMethodsInt.Sorter(commonMethodsInt.MyArray);
            Console.Write("Sorted myArray = ");
            commonMethodsInt.ShowArray();
            Console.WriteLine();
            Console.WriteLine("\n");
            
            commonMethodsInt = new InsertionSort<int>();
            
            // Create MyArray
            commonMethodsInt.MyArray = new int[4] { 4, 3, 2, 1 };

            // Sort MyArray using Insertion Sort
            commonMethodsInt.Sorter(commonMethodsInt.MyArray);
            Console.Write("Sorted myArray = ");
            commonMethodsInt.ShowArray();
            Console.WriteLine();
            Console.WriteLine("\n");

            CommonMethods<string> commonMethodsString = new InsertionSort<string>();

            // Create MyArray String
            commonMethodsString.MyArray = new string[] { "j", "r", "a", "uyr", "ew" };

            // Show unsorted MyArray
            Console.Write("Unsorted myArray = ");
            commonMethodsString.ShowArray();
            Console.WriteLine();
            Console.WriteLine();

            // Sort MyArray using Insertion Sort
            commonMethodsString.Sorter(commonMethodsString.MyArray);
            Console.Write("Sorted myArray = ");
            commonMethodsString.ShowArray();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
