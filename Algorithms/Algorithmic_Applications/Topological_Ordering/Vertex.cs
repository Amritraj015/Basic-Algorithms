using System.Collections.Generic;

namespace Topological_Ordering
{
    internal class Vertex
    {
        public string Data { get; set; }
        public bool Visited { get; set; }
        public List<Vertex> NeighborList { get; set; }

        public Vertex(string data)
        {
            Data = data;
            NeighborList = new List<Vertex>();
        }

        public void AddNeighbors(Vertex vertex)
        {
            NeighborList.Add(vertex);
        }

        public override string ToString()
        {
            return Data;
        }
    }
}
