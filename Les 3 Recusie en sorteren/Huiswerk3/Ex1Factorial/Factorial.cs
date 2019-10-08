namespace Huiswerk3
{
    public class Opgave1
    {
        public static long FacRecursive(int n)
        {
            long numb = 1;
            if (n >= 1)
            {
                numb = n * FacRecursive(n - 1);
            }
            return numb;
        }

        public static long FacIterative(int n)
        {
            long numb = 1;
            while (n != 1)
            {
                numb = numb * n;
                n = n - 1;
            }
            return numb;
        }

        public static void Run()
        {
            //------------------------------------------------------------
            // The factorial of 21 is too high to fit in a "long". That's
            // why from n=21, the result is negative
            //------------------------------------------------------------
            int MAX = 22;

            System.Console.WriteLine("Iteratief:");
            for (int n = 1; n < MAX; n++)
            {
                System.Console.WriteLine("          {0,2}! = {1,20}", n, FacIterative(n));
            }
            System.Console.WriteLine("Recursief:");
            for (int n = 1; n < MAX; n++)
            {
                System.Console.WriteLine("          {0,2}! = {1,20}", n, FacRecursive(n));
            }

        }
    }
}
