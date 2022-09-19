using System;
using System.Linq;
using System.Numerics;

namespace Dijkstra
{
    public class Dijkstra
    {
        internal void dijkstra(int[,] graph, int src)
        {
            int rows = graph.GetLength(0);
            int col = graph.GetLength(1);
            bool[] visited = new bool[rows];
            int[] distance = new int[rows];

            for(int i = 0; i < rows; ++i)
            { 
                visited[i] = false;
                distance[i] = int.MaxValue;
            }

            distance[src] = 0;
            for(int i = 0; i < rows; ++i)
            {
                int u = findMinDistance(distance, visited);
                visited[u] = true;

                for(int v = 0; v < rows; ++v)
                {
                    if(!visited[v]
                        && graph[u, v] != 0
                        && distance[u] + graph[u, v] < distance[v])
                    {
                        distance[v] = distance[u] + graph[u, v];
                    }
                }
            }

            for (int i = 0; i < distance.Count(); i++)
            {
                Console.WriteLine($"Distance from {src} to {i} is {distance[i]}");
            }

        }

        private int findMinDistance(int[] distance, bool[] visited)
        {
            int minDistance = int.MaxValue;
            int minDistanceVertex = -1;
            for(int i = 0; i < distance.Length; ++i)
            {
                if(!visited[i] && distance[i] < minDistance)
                {
                    minDistance = distance[i];
                    minDistanceVertex = i;
                }
            }

            return minDistanceVertex;
        }
    }
}
