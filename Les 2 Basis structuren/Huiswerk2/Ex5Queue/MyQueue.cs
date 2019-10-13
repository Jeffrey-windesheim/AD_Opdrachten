using System;
using System.Collections.Generic;

namespace Huiswerk2
{
    public class MyQueue<T> : IMyQueue<T>
    {
        public List<T> queue = new List<T>();

        public bool IsEmpty()
        {
            if(queue.Count == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void Enqueue(T data)
        {
            queue.Add(data);
        }

        public T GetFront()
        {
            if (IsEmpty())
            {
                throw new MyQueueEmptyException();
            } else
            {
                return queue[0];
            }
        }

        public T Dequeue()
        {
            var temp = GetFront();
            queue.RemoveAt(0);
            return temp;
        }

        public void Clear()
        {
            queue.Clear();
        }

    }
}