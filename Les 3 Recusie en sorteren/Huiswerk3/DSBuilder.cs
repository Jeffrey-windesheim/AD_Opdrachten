namespace Huiswerk3
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public class DSBuilder
    {
        public static Sorter CreateInsertionSorter()
        {
            return new InsertionSort();
        }

        public static Sorter CreateMergeSorter()
        {
            return new MergeSort();
        }

        public static Sorter CreateShellSorter()
        {
            return new ShellSort();
        }

    }
}
