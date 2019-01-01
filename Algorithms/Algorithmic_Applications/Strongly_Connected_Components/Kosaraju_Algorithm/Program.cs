using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosaraju_Algorithm
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var vertexList = new List<Vertex>
            {
                new Vertex(0, "a"),
                new Vertex(1, "b"),
                new Vertex(2, "c"),
                new Vertex(3, "d"),
                new Vertex(4, "e"),
                new Vertex(5, "f"),
                new Vertex(6, "g"),
                new Vertex(7, "h")
            };

            var edgeList = new List<Edge>
            {
                new Edge(1, vertexList[0], vertexList[1]),
                new Edge(1, vertexList[1], vertexList[2]),
                new Edge(1, vertexList[1], vertexList[4]),
                new Edge(1, vertexList[1], vertexList[5]),
                new Edge(1, vertexList[2], vertexList[3]),
                new Edge(1, vertexList[2], vertexList[6]),
                new Edge(1, vertexList[3], vertexList[2]),
                new Edge(1, vertexList[3], vertexList[7]),
                new Edge(1, vertexList[4], vertexList[0]),
                new Edge(1, vertexList[4], vertexList[5]),
                new Edge(1, vertexList[5], vertexList[6]),
                new Edge(1, vertexList[6], vertexList[5]),
                new Edge(1, vertexList[7], vertexList[3]),
                new Edge(1, vertexList[7], vertexList[6])
            };


            var graph = new Graph(vertexList, edgeList);

            //		for(Vertex v : graph.getTransposeGraph().getVertexList()){
            //			for(Vertex u : v.getAdjaenciesList()){
            //				System.out.println(v+"->"+u);
            //			}
            //		}

            var kosarajuAlgorithm = new KosarajuAlgorithm(graph);



            Console.WriteLine(kosarajuAlgorithm.GetCount());

            foreach (var vertex in vertexList)
            {
                Console.WriteLine(vertex + " - " + vertex.ComponentId);
            }

            Console.Read();
        }
    }
}
