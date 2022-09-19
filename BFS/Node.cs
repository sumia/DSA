using System.Collections.Generic;

namespace BFS
{
    public class Node
    {
        public int id { get; set; }
        public bool marked { get; set; }
        public List<Node> adjacents { get; set; }

        public Node(int id)
        {
            this.id = id;
        }

    }
}
