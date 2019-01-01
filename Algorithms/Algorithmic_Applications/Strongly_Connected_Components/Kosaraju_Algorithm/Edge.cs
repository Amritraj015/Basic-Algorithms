using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosaraju_Algorithm
{
    class Edge
    {
        public decimal Weight { get; set; }
        public Vertex StartingVertex { set; get; }
        public Vertex TargetVertex { get; set; }

        public Edge(decimal weight, Vertex startingVertex, Vertex targetVertex)
        {
            Weight = weight;
            StartingVertex = startingVertex;
            TargetVertex = targetVertex;
        }
    }
}
