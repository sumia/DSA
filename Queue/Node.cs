namespace Queue
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> next { get; set; }

        public Node(T data)
        {
            this.data = data;
        }

    }
}
