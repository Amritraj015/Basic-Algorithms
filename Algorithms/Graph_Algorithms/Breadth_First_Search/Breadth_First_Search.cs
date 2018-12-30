using System;
using System.Collections.Generic;

namespace Breadth_First_Search
{
    class BreadthFirstSearch
    {
        public void BFS(Vertex root)
        {
            var queue = new Queue<Vertex>();
            root.Visited = true;
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var actualVertex = queue.Dequeue();
                Console.Write(actualVertex + " ");

                foreach (var vertex in actualVertex.NeighborVerticesList)
                {
                    if (!vertex.Visited)
                    {
                        vertex.Visited = true;
                        queue.Enqueue(vertex);
                    }
                }
            }
        }
    }
}
