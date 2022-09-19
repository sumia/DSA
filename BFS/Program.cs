using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node0 = new Node(0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            node2.adjacents = new List<Node> { node1 };
            node4.adjacents = new List<Node>();
            node3.adjacents = new List<Node> { node2, node4 };
            node1.adjacents = new List<Node> { node3, node4 };
            node5.adjacents = new List<Node>();
            node0.adjacents = new List<Node> { node1, node4, node5 };


            BFS(node0);
            Console.ReadLine();
        }

        private static void BFS(Node root)
        {
            var queue = new Queue<Node>();
            root.marked = true;
            queue.Enqueue(root);

            while(queue.Count() > 0)
            {
                Node r = queue.Dequeue();
                visit(r);
                foreach(var n in r.adjacents)
                {
                    if(n.marked == false)
                    {
                        n.marked = true;
                        queue.Enqueue(n);
                    }
                }
                
            }
        }

        private static void visit(Node r)
        {
            Console.WriteLine($"Node {r.id}"); ;
        }
    }
}
