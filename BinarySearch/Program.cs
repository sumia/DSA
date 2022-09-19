using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var algo = new BinarySearchAlgo();

            var arr = new int[] { 1, 2, 3, 4, 5, 6 };
            int find = 7;
            Console.WriteLine($"Found {find} at {algo.BinarySearch(arr, find)}");
            Console.ReadLine();
        }
    }
}
