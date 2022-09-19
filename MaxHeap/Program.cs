using System;

namespace MaxHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MaxHeap maxHeap = new MaxHeap(15);
            maxHeap.Insert(5);
            maxHeap.Insert(3);
            maxHeap.Insert(17);
            maxHeap.Insert(10);
            maxHeap.Insert(84);
            maxHeap.Insert(19);
            maxHeap.Insert(6);
            maxHeap.Insert(22);
            maxHeap.Insert(9);

            maxHeap.Print();

            Console.WriteLine($"Max is {maxHeap.ExtractMax()}");
        }
    }
}
