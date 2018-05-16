using System;
using System.Collections.Generic;

namespace Dijkatra {
    public class GraphNode: IComparable<GraphNode>{
        public int val;
        public IList<Tuple<GraphNode, int>> neighbours;

        public GraphNode (int val) {
            this.val = val;
            this.neighbours = new List<Tuple<GraphNode, int>> ();
        }

        public int CompareTo(GraphNode other)
        {
            return this.val.CompareTo(other.val);
        }
    }
}