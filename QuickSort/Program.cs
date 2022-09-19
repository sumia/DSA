using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var algo = new QuickSortAlgo();

            var arr = new int[] { 7, 8, 1, 10, 0, 3, 13, 15, 5, 2 };
            algo.QuickSort(arr, 0, arr.Length - 1);

            Console.ReadLine();
        }
    }
}
