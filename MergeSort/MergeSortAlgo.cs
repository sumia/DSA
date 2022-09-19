using System;
using System.Linq;

namespace MergeSort
{
    public class MergeSortAlgo
    {
        public void MergeSort(int[] array)
        {
            int[] helper = new int[array.Length];
            MergeSort(array, helper, 0, array.Length - 1);
            Print(array);
        }

        private void Print(int[] array)
        {
            for(int i = 0; i< array.Length; ++i)
            {
                Console.Write($"{array.ElementAt(i)},");
            }
        }

        private void MergeSort(int[] array, int[] helper, int low, int high)
        {
            if(low < high)
            {
                int middle = (low + high) / 2;
                MergeSort(array, helper, low, middle);
                MergeSort(array, helper, middle + 1, high);
                Merge(array, helper, low, middle, high);
            }
        }

        private void Merge(int[] array, int[] helper, int low, int middle, int high)
        {
            //copy both halves into helper
            for(int i = low; i <= high; ++i)
            {
                helper[i] = array[i];
            }

            int helperLeft = low;
            int helperRight = middle + 1;
            int current = low;

            while(helperLeft <= middle && helperRight <= high)
            {
                if(helper[helperLeft] < helper[helperRight])
                {
                    array[current] = helper[helperLeft];
                    helperLeft++;
                } else
                {
                    array[current] = helper[helperRight];
                    helperRight++;
                }

                current++;
            }

            //copy rest of the left array into target array
            int remaining = middle - helperLeft;
            for(int i = 0; i <= remaining; ++i)
            {
                array[current + i] = helper[helperLeft + i]; 
            }
        }
    }
}
