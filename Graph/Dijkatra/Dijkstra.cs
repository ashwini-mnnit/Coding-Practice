using System;
using System.Collections.Generic;

namespace Dijkatra {
    public class Dijkstra {
        private int[] previous;
        private int[] distance;
        public void ShortestPath (Graph g, int source) {
            this.previous = new int[g.VerticesCount];
            this.distance = new int[g.VerticesCount];

            for (int i = 0; i < g.VerticesCount; i++) {
                this.previous[i] = -1;
                this.distance[i] = Int32.MaxValue;
            }

            HashSet<GraphNode>  unVisitedSet = new HashSet<GraphNode>();
            foreach (GraphNode node in g)
            {
                unVisitedSet.Add(node);
            }

            this.distance[source]=0;

            while(unVisitedSet.Count!=0)
            {
                GraphNode minDidtanceNode = GetMinDistanceNode(this.distance, unVisitedSet);

                unVisitedSet.Remove(minDidtanceNode);

                foreach(var neighbour in minDidtanceNode.neighbours)
                {
                    GraphNode n= neighbour.Item1;
                    int newDist = this.distance[minDidtanceNode.val] + neighbour.Item2;
                    if(newDist< this.distance[n.val])
                    {
                        this.distance[n.val]= newDist;
                        this.previous[n.val]= minDidtanceNode.val;
                    }
                }
                
            }
        }

        private GraphNode GetMinDistanceNode(int[] distance, HashSet<GraphNode> unVisitedSet)
        {
             // min distance node that is there in unVisitedSet
             // unVisitedSet.Count!= 0
             unVisitedSet.GetEnumerator().MoveNext();
             GraphNode rv = unVisitedSet.GetEnumerator().Current;
             foreach(GraphNode n in unVisitedSet)
             {
                 if(rv==null)
                 {
                     rv=n;
                 }
                 else if(distance[n.val] < distance[rv.val])
                 {
                     rv = n;
                 }
             }

             return rv;
        }
    }
}