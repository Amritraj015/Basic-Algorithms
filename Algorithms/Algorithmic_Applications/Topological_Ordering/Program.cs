using System;
using System.Collections.Generic;

namespace Topological_Ordering
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tOrder = new TopologicalOrdering();
            var graph = new List<Vertex>
            {
                new Vertex("0"),
                new Vertex("1"),
                new Vertex("2"),
                new Vertex("3"),
                new Vertex("4"),
                new Vertex("5")
            };

            graph[2].AddNeighbors(graph[3]);
            graph[3].AddNeighbors(graph[1]);
            graph[4].AddNeighbors(graph[0]);
            graph[4].AddNeighbors(graph[1]);
            graph[5].AddNeighbors(graph[0]);
            graph[5].AddNeighbors(graph[2]);

            foreach (var t in graph)
            {
                if(!t.Visited)
                    tOrder.Dfs(t);
            }

            var stack = tOrder.GetStack();

            for (var i = 0; i < graph.Count; ++i)
            {
                var vertex = stack.Pop();
                Console.Write(vertex + " => ");
            }


            Console.Read();
        }
    }
}
