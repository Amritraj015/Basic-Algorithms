using System;

namespace Breadth_First_Search
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var BFS = new BreadthFirstSearch();
            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);

            v1.AddNeighborVertices(v2);
            v1.AddNeighborVertices(v4);
            v4.AddNeighborVertices(v5);
            v2.AddNeighborVertices(v3);

            BFS.BFS(v1);

            Console.ReadKey();
        }
    }
}
