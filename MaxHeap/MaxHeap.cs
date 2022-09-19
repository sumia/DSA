using System;
using System.Linq.Expressions;

namespace MaxHeap
{
    public class MaxHeap
    {
        private int[] items;
        private int size;

        public MaxHeap(int size)
        {
            this.items = new int[size];
        }

        private int GetLeftChildIndex(int pos) => 2 * pos + 1;
        private int GetRightChildIndex(int pos) => 2 * pos + 2;
        private int GetParentIndex(int pos) => (pos - 1) / 2;

        private bool HasLeftChild(int pos) => GetLeftChildIndex(pos) < size;

        internal void Print()
        {
            for(int i = 0; i < size/2; ++i)
            {
                Console.Write($"Parent: {items[i]}");
                if (HasLeftChild(i)) Console.Write($", Left: {GetLeftChild(i)}");
                if (HasRightChild(i)) Console.Write($", Right: {GetRightChild(i)}");
                Console.WriteLine();
            }

            
        }

        private bool HasRightChild(int pos) => GetRightChildIndex(pos) < size;
        private bool IsRoot(int pos) => pos == 0;

        private int GetLeftChild(int pos) => items[GetLeftChildIndex(pos)];
        private int GetRightChild(int pos) => items[GetRightChildIndex(pos)];
        private int GetParent(int pos) => items[GetParentIndex(pos)];

        private void Swap(int firstIndex, int lastIndex)
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
            int index = size - 1;
            while(!IsRoot(index) && items[index] > GetParent(index))
            {
                int parentIndex = GetParentIndex(index);
                Swap(index, parentIndex);
                index = parentIndex;
            }
        }

        public int ExtractMax()
        {
            int root = items[0];

            //put last item at the top
            items[0] = items[size - 1];

            //reduce size
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
                int biggerIndex = GetLeftChildIndex(index);
                if(HasRightChild(index) && GetRightChild(index) > GetLeftChild(index))
                {
                    index = GetRightChildIndex(index);
                }

                if (items[index] >= items[biggerIndex]) break;

                Swap(index, biggerIndex);
                index = biggerIndex;
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
