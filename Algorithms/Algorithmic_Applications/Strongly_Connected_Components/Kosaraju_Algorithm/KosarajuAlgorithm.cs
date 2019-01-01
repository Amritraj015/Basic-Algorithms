using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosaraju_Algorithm
{
    internal class KosarajuAlgorithm
    {
        public int[] Id; //IDs for the strongly connected components.
        public int Count;
        public bool[] Marked;

        public KosarajuAlgorithm(Graph grapg)
        {
            var Dfo = new DepthFirstOrder(grapg.GetTransposeGraph());
            Marked = new bool[grapg.VertexList.Count];
            Id = new int[grapg.VertexList.Count];

            foreach (var vertex in Dfo.GetReversePost())
            {
                if (!Marked[vertex.Id])
                {
                    this.Dfs(vertex);
                    Count++;
                }
            }
        }

        public void Dfs(Vertex vertex)
        {
            Marked[vertex.Id] = true;
            Id[vertex.Id] = Count;
            vertex.ComponentId = Count;

            foreach (var v in vertex.AdjacencyList)
            {
                if (!Marked[v.Id])
                {
                    Dfs(v);
                }
            }
        }

        public int GetCount()
        {
            return Count;
        }
    }
}
