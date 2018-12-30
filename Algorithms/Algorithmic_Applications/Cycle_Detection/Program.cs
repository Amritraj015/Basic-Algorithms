using System;
using System.Collections.Generic;

namespace Cycle_Detection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var vertex1 = new Vertex("1");
            var vertex2 = new Vertex("2");
            var vertex3 = new Vertex("3");
            var vertex4 = new Vertex("4");
            var vertex5 = new Vertex("5");
            var vertex6 = new Vertex("6");

            vertex1.AddNeighborVertices(vertex2);
            vertex2.AddNeighborVertices(vertex3);
            vertex3.AddNeighborVertices(vertex1);
            vertex4.AddNeighborVertices(vertex1);
            vertex4.AddNeighborVertices(vertex5);
            vertex5.AddNeighborVertices(vertex6);
            vertex6.AddNeighborVertices(vertex4);

            var vertexList = new List<Vertex>
            {
                vertex1,
                vertex2,
                vertex3,
                vertex4,
                vertex5,
                vertex6
            };

            var cycleDetection = new CycleDetection();
            cycleDetection.DetectCycles(vertexList);

            Console.Read();
        }
    }
}
