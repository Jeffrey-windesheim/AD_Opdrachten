using System;
using System.Text;

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
            size = 0;
            array = new T[DEFAULT_CAPACITY];
        }

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------
        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            size = 0;
        }

        public void Add(T x)
        {
            int hole = size++;
            array[0] = x;

            for (; x.CompareTo(array[hole / 2]) < 0; hole /= 2)
            {
                array[hole] = array[hole / 2];
            }

            array[hole] = x;
        }

        // Removes the smallest item in the priority queue
        public T Remove()
        {
            T minItem = Element();
            array[1] = array[size--];
            PercolateDown(1);
            
            return minItem;
        }

        public T Element()
         {
            if (size == 0)
            {
                throw new PriorityQueueEmptyException();
            }

            return array[1];
         }

        private void PercolateDown(int hole)
        {
            int child;
            T tmp = array[hole];

            for(; hole* 2 <= size; hole = child)
            {
                child = hole* 2;
                if (child != size && array[child + 1].CompareTo(array[child]) < 0)
                {
                    child++;
                }
                if (array[child].CompareTo(tmp) < 0)
                {
                    array[hole] = array[child];
                } else
                {
                    break;
                }
                    
            }

            array[hole] = tmp;
        }

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public void AddFreely(T x)
        {
            array[++size] = x;
        }

        public void BuildHeap()
        {
            for (int i = size / 2; i > 0; i--)
            {
                PercolateDown(i);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= size; i++)
            {
                sb.Append(array[i]);
                if (i + 1 <= size)
                {
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }
    }
}
