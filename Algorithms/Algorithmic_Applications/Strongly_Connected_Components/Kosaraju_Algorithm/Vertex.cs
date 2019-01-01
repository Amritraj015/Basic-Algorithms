using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosaraju_Algorithm
{
    internal class Vertex
    {
        public int Id { get; set; }
        public bool Visited { get; set; }
        public int ComponentId { get; set; }
        public string Name { get; set; }
        public List<Vertex> AdjacencyList { get; set; }

        public Vertex(int id, string name)
        {
            Id = id;
            Name = name;
            AdjacencyList = new List<Vertex>();
        }

        public void AddNeighbor(Vertex vertex)
        {
            AdjacencyList.Add(vertex);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
