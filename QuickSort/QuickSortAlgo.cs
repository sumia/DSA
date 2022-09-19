using System;
using System.Collections.Concurrent;

namespace QuickSort
{
    public class QuickSortAlgo
    {
        public void QuickSort(int[] arr, int left, int right)
        {
            int index = Partition(arr, left, right);
            Console.WriteLine($"Pivot: {arr[index]}");
            if(left < index - 1)
            {
                QuickSort(arr, left, index - 1);
            }

            if(index < right)
            {
                QuickSort(arr, index, right);
            }

            Print(arr);
        }

        private void Print(int[] arr)
        {
            for(int i=0; i<arr.Length; ++i)
            {
                Console.Write($"{arr[i]},");
            }
            Console.WriteLine();
        }

        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];
            while(left <=right)
            {
                while (arr[left] < pivot) ++left;
                while (arr[right] > pivot) --right;

                if(left <= right)
                {
                    swap(arr, left, right);
                    ++left;
                    --right;
                }
            }

            return left;
        }

        private void swap(int[] arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
}
