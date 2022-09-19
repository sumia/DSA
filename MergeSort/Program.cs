using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var algo = new MergeSortAlgo();


            algo.MergeSort(new int[] { 7, 8, 1, 10, 0 });

            Console.ReadLine();
        }
    }
}
