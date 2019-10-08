
namespace Huiswerk2
{
    public class MyStack<T> : IMyStack<T>
    {
        public MyLinkedList<T> stack;

        public MyStack()
        {
            stack = new MyLinkedList<T>();
        }

        public bool IsEmpty()
        {
            if (stack.Size() == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new MyStackEmptyException();
            }
            else
            {
                T data = stack.GetFirst();
                stack.RemoveFirst();

                return data;
            }
        }

        public void Push(T data)
        {
            stack.AddFirst(data);
        }

        public T Top()
        {
            if (IsEmpty()) {
                throw new MyStackEmptyException();
            } 
            else
            {
                return stack.GetFirst();
            }
            
        }
    }
}
