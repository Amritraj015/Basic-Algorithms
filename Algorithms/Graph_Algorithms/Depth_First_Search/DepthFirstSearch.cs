using System;
using System.Collections.Generic;

namespace Depth_First_Search
{
    internal class DepthFirstSearch
    {
        private readonly Stack<Vertex> _stack;

        public DepthFirstSearch()
        {
            _stack = new Stack<Vertex>();
        }

        public void Dfs(List<Vertex> vertexList)
        {
            foreach (var vertex in vertexList)
            {
                if (vertex.Visited) continue;
                vertex.Visited = true;
                
                //======================================
                //  Use one of the Following Methods
                //======================================

                //DfsWithStack(vertex);
                DfsWithRecursion(vertex);
            }
        }

        private void DfsWithRecursion(Vertex rootVertex)
        {
            Console.Write(rootVertex + " ");
            foreach (var vertex in rootVertex.NeighborList)
            {
                if (vertex.Visited) continue;
                vertex.Visited = true;
                DfsWithRecursion(vertex);
            }
        }

        private void DfsWithStack(Vertex rootVertex)
        {
            _stack.Push(rootVertex);
            rootVertex.Visited = true;

            while (_stack.Count != 0)
            {
                var actualVertex = _stack.Pop();
                Console.Write(actualVertex + " ");

                foreach (var vertex in actualVertex.NeighborList)
                {
                    if (vertex.Visited) continue;
                    vertex.Visited = true;
                    _stack.Push(vertex);
                }
            }
        }
    }
}
