using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosaraju_Algorithm
{
    internal class Graph
    {
        public List<Vertex> VertexList { get; set; }
        public List<Edge> EdgeList { get; set; }

        public Graph()
        {
        }

        public Graph(List<Vertex> vertexList, List<Edge> edgeList)
        {
            VertexList = vertexList;
            EdgeList = edgeList;
        }

        public Graph GetTransposeGraph()
        {
            var transposed = new Graph();
            var transposedVertexList = new List<Vertex>();
            foreach (var vertex in VertexList)
            {
                transposedVertexList.Add(vertex);
            }

            foreach (var edge in EdgeList)
            {
                transposedVertexList[transposedVertexList.IndexOf(edge.TargetVertex)].AddNeighbor(edge.StartingVertex);
            }

            transposed.VertexList = transposedVertexList;

            return transposed;
        }
    }
}
