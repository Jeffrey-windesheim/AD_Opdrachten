using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huiswerk6
{
    public class Graph : IGraph
    {
        public static readonly double INFINITY = System.Double.MaxValue;

        private Dictionary<string, Vertex> vertexMap;


        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------

        public Graph()
        {
            vertexMap = new Dictionary<string, Vertex>();
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public Vertex GetVertex(string name)
        {
            Vertex v;
            if (!vertexMap.TryGetValue(name, out v))
            {
                v = new Vertex(name);
                vertexMap.Add(name, v);
            }
            return v;
        }

        public void AddEdge(string source, string dest, double cost)
        {
            Vertex v = GetVertex(source);
            Vertex w = GetVertex(dest);
            v.adj.Add(new Edge(w, cost));
        }

        public void ClearAll()
        {
            //throw new System.NotImplementedException();
        }


        //----------------------------------------------------------------------
        // ToString that has to be implemented for exam
        //----------------------------------------------------------------------

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            List<string> list = vertexMap.Keys.ToList();
            list.Sort();
            foreach (string key in list)
            {
                sb.Append(vertexMap[key]);
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public void Unweighted(string startName)
        {
            ClearAll();

            Vertex start;
            if (!vertexMap.TryGetValue(startName, out start))
            {
                throw new Exception("Start vertex not found");
            }
            Queue<Vertex> q = new Queue<Vertex>();
            q.Enqueue(start);
            start.dist = 0;

            while (q.Count != 0)
            {
                Vertex v = q.Dequeue();
                foreach (Edge e in v.adj)
                {
                    Vertex w = e.dest;
                    if (w.dist == INFINITY)
                    {
                        w.dist = v.dist + 1;
                        w.prev = v;
                        q.Enqueue(w);
                    }
                }
            }

        }

        public void Dijkstra(string startName)
        {
            //throw new System.NotImplementedException();

            //GraphPriorityQueue pq = new GraphPriorityQueue();

            //Vertex start;
            //if (!vertexMap.TryGetValue(startName, out start))
            //{
            //    throw new ArgumentException("Start vertex not found");
            //}
            //ClearAll();
            //pq.Add(new Path(start, 0));
            //start.dist = 0;
            //int nodesSeen = 0;
            //while (!pq.isEmpty() && nodesSeen < vertexMap.Count)
            //{
            //    Path vrec = pq.Remove();
            //    Vertex v = vrec.dest;
            //    if (v.scratch != null)
            //        continue;
            //    v.scratch = 1;
            //    nodesSeen++;

            //    foreach (Edge e in v.adj)
            //    {
            //        Vertex w = e.dest;
            //        double cvw = e.cost;
            //        if (cvw < 0)
            //            throw new ArgumentException("Graph has negative edges");

            //        if (w.dist > v.dist + cvw)
            //        {
            //            w.dist = v.dist + cvw;
            //            w.prev = v;
            //            pq.Add(new Path(w, w.dist));
            //        }
            //    }
            //}
        }

        public bool IsConnected()
        {
            throw new System.NotImplementedException();
        }

    }
}