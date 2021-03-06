﻿using System;

namespace Huiswerk3
{
    public class Opgave4
    {
        public static int Enen(int n)
        {
            string binary = Convert.ToString(n, 2);
            int count = 0;
            foreach (char c in binary)
            {
                if (c == '1')
                {
                    count++;
                }
            }

            return count;
        }

        public static void Run()
        {
            for (int i = 0; i < 20; i++)
            {
                System.Console.WriteLine("Enen({0,4}) = {1,2}", i, Enen(i));
            }
            System.Console.WriteLine("Enen(1024) = {0,2}", Enen(1024));
            System.Console.WriteLine();
        }
    }
}
