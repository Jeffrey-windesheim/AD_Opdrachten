using System;

namespace Huiswerk2
{
    public interface IMyQueue<T>
    {
        bool IsEmpty();
        void Enqueue(T data);
        T GetFront();
        T Dequeue();
        void Clear();
    }

    public class MyQueueEmptyException : Exception
    {
    }
}