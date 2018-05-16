using System;

namespace Dijkatra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph g = new Graph();
            for(int i=0;i<9;i++)
            {
                g.AddVertex(i);
            }

            g.AddEdge(0,1,4);
            g.AddEdge(0,7,8);
            g.AddEdge(1,7,11);
            g.AddEdge(1,2,8);
            g.AddEdge(7,8,7);
            g.AddEdge(7,6,1);
            g.AddEdge(8,2,2);
            g.AddEdge(8,6,6);
            g.AddEdge(2,3,7);
            g.AddEdge(2,5,4);
            g.AddEdge(6,5,2);
            g.AddEdge(3,5,14);
            g.AddEdge(4,4,9);
            g.AddEdge(5,4,10);


            Dijkstra dj = new Dijkstra();
            dj.ShortestPath(g, 0);
        }
    }
}
