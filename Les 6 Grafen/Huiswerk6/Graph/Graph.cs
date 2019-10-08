using System.Collections.Generic;

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
            throw new System.NotImplementedException();
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public Vertex GetVertex(string name)
        {
            throw new System.NotImplementedException();
        }

        public void AddEdge(string source, string dest, double cost)
        {
            throw new System.NotImplementedException();
        }

        public void ClearAll()
        {
            throw new System.NotImplementedException();
        }


        //----------------------------------------------------------------------
        // ToString that has to be implemented for exam
        //----------------------------------------------------------------------

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }


        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public void Unweighted(string name)
        {
            throw new System.NotImplementedException();
        }

        public void Dijkstra(string name)
        {
            throw new System.NotImplementedException();
        }

        public bool IsConnected()
        {
            throw new System.NotImplementedException();
        }

    }
}