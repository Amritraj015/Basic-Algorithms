using System;
using System.Collections.Generic;

namespace Cycle_Detection
{
    internal class CycleDetection
    {
        public void DetectCycles(List<Vertex> vertexList)
        {
            foreach (var vertex in vertexList)
            {
                if (!vertex.IsVisited)
                    Dfs(vertex);
            }
        }

        private static void Dfs(Vertex vertex)
        {
            Console.WriteLine("DFS on vertex " + vertex);
            vertex.IsBeingVisited = true;

            foreach (var v in vertex.NeighborVertices)
            {
                Console.WriteLine("Visiting neighbors of vertex " + vertex);
                if (v.IsBeingVisited)
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine("\tBackward Edge Found => There is a cycle");
                    Console.WriteLine("=======================================================");
                    return;
                }

                if (!v.IsVisited)
                {
                    Console.WriteLine("Visiting vertex " + v + " recursively.");
                    v.IsVisited = true;
                    Dfs(v);
                }
            }

            Console.WriteLine("Setting vertex " + vertex + " isBeingVisited = false, and isVisied = true.");
            vertex.IsVisited = true;
            vertex.IsBeingVisited = false;
        }
    }
}
