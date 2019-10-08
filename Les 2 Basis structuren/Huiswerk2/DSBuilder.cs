namespace Huiswerk2
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public class DSBuilder
    {
        public static IMyArrayList CreateMyArrayList()
        {
            return new MyArrayList(5);
        }

        public static IMyLinkedList<string> CreateMyLinkedList()
        {
            return new MyLinkedList<string>();
        }

        public static IMyStack<string> CreateMyStack()
        {
            return new MyStack<string>();
        }

        public static IMyQueue<string> CreateMyQueue()
        {
            return new MyQueue<string>();
        }

    }
}
