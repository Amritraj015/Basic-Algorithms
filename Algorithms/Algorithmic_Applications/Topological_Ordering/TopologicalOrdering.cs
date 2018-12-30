using System.Collections.Generic;

namespace Topological_Ordering
{
    internal class TopologicalOrdering
    {
        public Stack<Vertex> Stack;

        public TopologicalOrdering()
        {
            Stack = new Stack<Vertex>();
        }

        public void Dfs(Vertex vertex)
        {
            vertex.Visited = true;

            foreach (var v in vertex.NeighborList)
            {
                if (v.Visited) continue;
                v.Visited = true;
                Dfs(v);
            }

            Stack.Push(vertex);
        }

        public Stack<Vertex> GetStack()
        {
            return Stack;
        }
    }
}
