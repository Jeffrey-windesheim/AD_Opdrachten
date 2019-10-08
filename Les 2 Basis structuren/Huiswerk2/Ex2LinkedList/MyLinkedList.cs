using System.Collections.Generic;

namespace Huiswerk2
{
    public class MyLinkedList<T> : IMyLinkedList<T>
    {
        public MyNode<T> header;
        private int size;

        public MyLinkedList()
        {
            header = new MyNode<T>();
        }

        public void AddFirst(T data)
        {
            MyNode<T> node = new MyNode<T> { data = data, next = header.next };
            header.next = node;
            size++;
        }

        public T GetFirst()
        {
            if (size == 0)
            {
                throw new MyLinkedListEmptyException();
            } else
            {
                return header.next.data;
            }
        }

        public void RemoveFirst()
        {
            if (size > 0)
            {
                if (header != null)
                {
                    header.next = header.next.next;
                    size--;
                }
                
            } else
            {
                throw new MyLinkedListEmptyException();
            }
        }

        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            while (size > 0)
            {
                RemoveFirst();
            }
            size = 0;
        }

        public void Insert(int index, T data)
        {
            if (index == 0)
            {
                AddFirst(data);
            } else if (index >= 0 && index <= size) {
                MyNode<T> current = header;
                for (int i = 0; i < index; i++)
                {
                    current = current.next;
                }
                MyNode<T> next = current.next;
                current.next = new MyNode<T>() { data = data, next = next };

                size++;
            } else
            {
                throw new MyLinkedListIndexOutOfRangeException();
            }
        }

        public override string ToString()
        {
            if (size == 0)
            {
                return "NIL";
            }
            else
            {
                MyNode<T> temp = header;
                List<T> numberList = new List<T>();
                while (temp != null)
                {
                    if (temp.data != null)
                    {
                        numberList.Add(temp.data);
                    }
                    temp = temp.next;
                }
                numberList.ToArray();

                string numbers = string.Join(",", numberList);
                numbers = "[" + numbers + "]";

                return numbers;
            }
        }
    }
}
