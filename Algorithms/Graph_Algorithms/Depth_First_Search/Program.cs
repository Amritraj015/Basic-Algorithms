using System;
using System.Collections.Generic;

namespace Depth_First_Search
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var v1 = new Vertex("1");
            var v2 = new Vertex("2");
            var v3 = new Vertex("3");
            var v4 = new Vertex("4");
            var v5 = new Vertex("5");

            var list = new List<Vertex>();

            v1.AddNeighbor(v2);
            v1.AddNeighbor(v3);
            v3.AddNeighbor(v4);
            v4.AddNeighbor(v5);

            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            list.Add(v4);
            list.Add(v5);

            var dfs = new DepthFirstSearch();
            dfs.Dfs(list);

            Console.ReadKey();
        }
    }
}
