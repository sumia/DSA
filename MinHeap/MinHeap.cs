using System;
namespace MinHeap
{
    //root is smaller than its children
    //https://egorikas.com/max-and-min-heap-implementation-with-csharp/
    public class MinHeap
    {
        private int[] items;
        private int size;

        public MinHeap(int capacity)
        {
            items = new int[capacity];
            size = 0;
        }

        public int GetLeftChildIndex(int pos) => 2 * pos + 1;
        public int GetRightChildIndex(int pos) => 2 * pos + 2;
        public int GetParentIndex(int pos) => (pos - 1) / 2;

        public bool HasLeftChild(int pos) => GetLeftChildIndex(pos) < size;
        public bool HasRightChild(int pos) => GetRightChildIndex(pos) < size;
        public bool IsRoot(int pos) => pos == 0;

        public int GetLeftChild(int pos) => items[GetLeftChildIndex(pos)];
        public int GetRightChild(int pos) => items[GetRightChildIndex(pos)];
        public int GetParent(int pos) => items[GetParentIndex(pos)];

        public void Swap(int firstIndex, int lastIndex)
        {
            int temp = items[firstIndex];
            items[firstIndex] = items[lastIndex];
            items[lastIndex] = temp;
        }

        public void Insert(int item)
        {
            if (size == items.Length) throw new IndexOutOfRangeException();

            items[size] = item;
            ++size;

            RecalculateUp();
        }

        private void RecalculateUp()
        {
            var index = size - 1;
            while(!IsRoot(index) && items[index] < GetParent(index))
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

        public int ExtractMin()
        {
            var root = items[0];

            //put the last item at the top
            items[0] = items[items.Length - 1];

            //reduce array size
            size = size - 1;

            //rebalance
            RecalculateDown();

            return root;
        }

        private void RecalculateDown()
        {
            int index = 0;
            while(HasLeftChild(index))
            {
                var smallerIndex = GetLeftChildIndex(index);
                if(HasRightChild(index) && GetRightChild(index) < GetLeftChild(index))
                {
                    smallerIndex = GetRightChildIndex(index);
                }

                if (items[smallerIndex] >= items[index]) break;

                Swap(index, smallerIndex);
                index = smallerIndex;
            }
        }

        public int Peek()
        {
            if (IsEmpty()) throw new IndexOutOfRangeException();
            return items[0];
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
    }
}
