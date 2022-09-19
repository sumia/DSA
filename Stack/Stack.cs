using System;
namespace Stack
{
    public class Stack<T>
    {
        public Node<T> top;

        public void Push(T data)
        {
            var node = new Node<T>(data);
            node.next = top;
            top = node;
        }

        public T Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException();

            T data = top.data;
            top = top.next;

            return data;
        }


        public T Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException();

            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

    }
}
