using System;
namespace Queue
{
    public class Queue<T>
    {
        private Node<T> first;
        private Node<T> last;


        public void Enqueue(T data)
        {
            var node = new Node<T>(data);
            if(last != null) last.next = node;

            last = node;

            if (first == null) first = last;

        }

        public T Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException();

            T data = first.data;
            first = first.next;

            if (first == null) last = null;

            return data;
        }

        public T Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException();

            return first.data;
        }

        public bool IsEmpty()
        {
            return first == null;
        }


    }
}
