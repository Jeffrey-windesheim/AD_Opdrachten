using System;

namespace Huiswerk5
{
    public class PriorityQueue<T> : IPriorityQueue<T>
        where T : IComparable<T>
    {
        public static int DEFAULT_CAPACITY = 100;
        public int size;   // Number of elements in heap
        public T[] array;  // The heap array

       //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------
        public PriorityQueue()
        {
            throw new NotImplementedException();
        }

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------
        public int Size()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Add(T x)
        {
            throw new NotImplementedException();
        }

        // Removes the smallest item in the priority queue
        public T Remove()
        {
            throw new NotImplementedException();
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public void AddFreely(T x)
        {
            throw new NotImplementedException();
        }

        public void BuildHeap()
        {
            throw new NotImplementedException();
        }
    }
}
