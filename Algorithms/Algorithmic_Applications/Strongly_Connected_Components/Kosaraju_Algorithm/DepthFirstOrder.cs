using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kosaraju_Algorithm
{
    internal class DepthFirstOrder
    {
        public Stack<Vertex> Stack;

        public DepthFirstOrder(Graph graph)
        {
            Stack = new Stack<Vertex>();

            foreach (var vertex in graph.VertexList)
            {
                if (!vertex.Visited)
                {
                    Dfs(vertex);
                }
            }
        }

        private void Dfs(Vertex vertex)
        {
            vertex.Visited = true;

            foreach (var v in vertex.AdjacencyList)
            {
                if (!v.Visited)
                {
                    Dfs(v);
                }
            }

            Stack.Push(vertex);
        }

        public Stack<Vertex> GetReversePost()
        {
            return Stack;
        }
    }
}
