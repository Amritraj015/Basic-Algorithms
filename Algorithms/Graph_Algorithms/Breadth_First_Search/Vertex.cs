using System.Collections.Generic;

namespace Breadth_First_Search
{
    class Vertex
    {
        public int Data { get; set; }
        public bool Visited { get; set; }
        public List<Vertex> NeighborVerticesList { get; set; }

        public Vertex(int data)
        {
            Data = data;
            NeighborVerticesList = new List<Vertex>();
        }

        public void AddNeighborVertices(Vertex vertex)
        {
            NeighborVerticesList.Add(vertex);
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
