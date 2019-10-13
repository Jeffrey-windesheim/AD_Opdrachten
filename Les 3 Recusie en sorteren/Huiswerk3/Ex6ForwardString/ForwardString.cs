using System;
using System.Collections.Generic;

namespace Huiswerk3
{
    public class Opgave6
    {
        public static string ForwardString(List<int> list, int from)
        {
            string result = "";

            foreach (int number in list)
            {
                if (number >= from)
                {
                    result += number.ToString() + " ";
                }
            }

            return result;
        }
        
        public static string BackwardString(List<int> list, int to)
        {
            string result = "";

            foreach (int number in list)
            {
                if (number >= to)
                {
                    string temp = number.ToString() + " " + result;
                    result = temp;
                }
            }
            
            return result;
        }

        public static void Run()
        {
            List<int> list = new List<int>(new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11});

            System.Console.WriteLine(ForwardString(list, 3));
            System.Console.WriteLine(ForwardString(list, 7));
            System.Console.WriteLine(BackwardString(list, 3));
            System.Console.WriteLine(BackwardString(list, 7));
        }
    }
}
