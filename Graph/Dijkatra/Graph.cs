using System;
using System.Collections;
using System.Collections.Generic;

namespace Dijkatra {
    public class Graph : IEnumerable<GraphNode> {

        //public IList<GraphNode> vertices; 
        private Dictionary<int, GraphNode> verticesDict;        

        public Graph () {
            //this.vertices = new List<GraphNode> ();
            this.verticesDict = new Dictionary<int, GraphNode>();
        }

        public void AddVertex(int val)
        {
            GraphNode n = new GraphNode(val);
            this.verticesDict.Add(val, n);
        }

        public void AddEdge(int src, int dest, int weight)
        {
            if(!this.verticesDict.ContainsKey(src)|| !this.verticesDict.ContainsKey(dest))
            {
                //Assume vertices are present or throw exeception
                throw new System.Exception("src or dest not present");
            }

            this.verticesDict[src].neighbours.Add(new Tuple<GraphNode, int>(this.verticesDict[dest], weight));
            
        }

        public IEnumerator<GraphNode> GetEnumerator()
        {
            return this.verticesDict.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.verticesDict.Values.GetEnumerator();
        }

        public int VerticesCount
        {
            get
            {
                return this.verticesDict.Count;
            }
        }
    }
}