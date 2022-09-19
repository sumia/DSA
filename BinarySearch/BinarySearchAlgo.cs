using System;
namespace BinarySearch
{
    public class BinarySearchAlgo
    {
        public int BinarySearch(int[] arr, int n)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid;

            while (low <= high)
            {
                mid = (low + high) / 2;
                if (arr[mid] == n) return mid;

                if(n < arr[mid])
                {
                    high = mid - 1;
                } else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }

        public int BinarySearchRecursive(int[] arr, int n, int low, int high)
        {
            if (low > high) return -1;
            int mid = (low + high) / 2;
            if (arr[mid] == n) return mid;
            else if(n < arr[mid])
            {
                return BinarySearchRecursive(arr, n, 0, mid - 1);
            } else
            {
                return BinarySearchRecursive(arr, n, mid + 1, high);
            }
        }
    }
}
