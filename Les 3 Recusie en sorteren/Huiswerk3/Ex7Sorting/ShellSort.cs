using System.Collections.Generic;


namespace Huiswerk3
{
    public class ShellSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            int length = list.Count;

            for (int h = length / 2; h > 0; h /= 2)
            {
                for (int i = h; i < length; i += 1)
                {
                    int temp = list[i];

                    int j;
                    for (j = i; j >= h && list[j - h] > temp; j -= h)
                    {
                        list[j] = list[j - h];
                    }

                    list[j] = temp;
                }
            }
        }
    }
}
