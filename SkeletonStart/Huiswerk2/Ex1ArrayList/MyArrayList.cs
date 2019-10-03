using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Huiswerk2
{
    public class MyArrayList : IMyArrayList
    {
        private int[] data;
        private int size;

        public MyArrayList(int capacity)
        {
            data = new int[capacity];
            //throw new NotImplementedException();
        }

        public void Add(int n)
        {
            if (Capacity() != size)
            {
                data[size] = n;
                size++;
            } else
            {
                throw new MyArrayListFullException();
            }
            
            //throw new NotImplementedException();
        }

        public int Get(int index)
        {
            if (index < size && size > 0 && index >= 0)
            {
                return data[index];
            } else
            {
                throw new MyArrayListIndexOutOfRangeException();
            }

            //throw new NotImplementedException();
        }

        public void Set(int index, int n)
        {
            if (index < size && size > 0 && index >= 0)
            {
                data.SetValue(n, index);
            }
            else
            {
                throw new MyArrayListIndexOutOfRangeException();
            }
            
            //throw new NotImplementedException();
        }

        public int Capacity()
        {
            return data.Length;
            //throw new NotImplementedException();
        }

        public int Size()
        {
            return size;
            //throw new NotImplementedException();
        }

        public void Clear()
        {
            Array.Clear(data, 0, Capacity());
            size = 0;
            //throw new NotImplementedException();
        }

        public int CountOccurences(int n)
        {
            int occurences = 0;
            foreach(int number in data)
            {
                if(number == n)
                {
                    occurences++;
                }
            }
            return occurences;
            //throw new NotImplementedException();
        }

        public override string ToString()
        {
            string numbers = "";
            if (size > 0)
            {
                numbers = "[";
                for (int i = 0; i < size; i++)
                {
                    numbers += data[i] + ",";
                }
                numbers = numbers.Remove(numbers.Length - 1) + "]";
            } else
            {
                numbers = "NIL";
            }

            return numbers;
        }
    }
}
