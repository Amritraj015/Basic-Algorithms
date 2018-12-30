using System.Collections.Generic;

namespace Depth_First_Search
{
    class Vertex
    {
        public string Name { get; set; }
        public bool Visited { get; set; }
        public List<Vertex> NeighborList { get; set; }

        public Vertex(string name)
        {
            this.Name = name;
            NeighborList = new List<Vertex>();
        }

        public void AddNeighbor(Vertex vertex)
        {
            NeighborList.Add(vertex);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
