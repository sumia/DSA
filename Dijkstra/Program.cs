using System;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var graph = new int[,] {
                { 0, 0, 1, 2, 0, 0, 0 },
                { 0, 0, 2, 0, 0, 3, 0 },
                { 1, 2, 0, 1, 3, 0, 0 },
                { 2, 0, 1, 0, 0, 0, 1 },
                { 0, 0, 3, 0, 0, 2, 0 },
            };

            Dijkstra T = new Dijkstra();
            T.dijkstra(graph, 0);

            Console.ReadLine();
        }
    }
}
