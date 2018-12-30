using System.Collections.Generic;

namespace Cycle_Detection
{
    internal class Vertex
    {
        public string Data { get; set; }
        public bool IsVisited { get; set; }
        public bool IsBeingVisited { get; set; }
        public List<Vertex> NeighborVertices;

        public Vertex(string data)
        {
            Data = data;
            NeighborVertices = new List<Vertex>();
        }

        public void AddNeighborVertices(Vertex vertex)
        {
            NeighborVertices.Add(vertex);
        }

        public override string ToString()
        {
            return Data;
        }
    }
}
