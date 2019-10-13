using System;
using System.Collections.Generic;


namespace Huiswerk3
{
    public class InsertionSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            int n = list.Count;
            for (int i = 1; i < n; ++i)
            {
                int key = list[i];
                int j = i - 1;
                
                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }
        }
    }
}
