using System;
using System.Collections.Generic;
using System.Linq;

namespace Huiswerk3
{
    public class MergeSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            int[] a = list.ToArray();
            int[] tmpArray = new int[a.Length];
            
            mergeSort(a, tmpArray, 0, a.Length - 1);

            list.Clear();

            foreach(int n in a)
            {
                list.Add(n);
            }
        }

        private static void mergeSort(int[] a, int[] tmpArray, int left, int right)
        {
            if(left < right)
            {
                int center = (left + right) / 2;
                mergeSort(a, tmpArray, left, center);
                mergeSort(a, tmpArray, center + 1, right);
                merge(a, tmpArray, left, center + 1, right);
            }
        }

        private static void merge(int[] a, int[] tmpArray, int leftPos, int rightPos, int rightEnd)
        {
            int leftEnd = rightPos - 1;
            int tmpPos = leftPos;
            int numElements = rightEnd - leftPos + 1;

            while (leftPos <= leftEnd && rightPos <= rightEnd)
            {
                if(a[leftPos].CompareTo(a[rightPos]) <= 0)
                {
                    tmpArray[tmpPos++] = a[leftPos++];
                } else
                {
                    tmpArray[tmpPos++] = a[rightPos++];
                }
            }

            while (leftPos <= leftEnd)
            {
                tmpArray[tmpPos++] = a[leftPos++];
            }

            while (rightPos <= rightEnd)
            {
                tmpArray[tmpPos++] = a[rightPos++];
            }

            for (int i = 0; i < numElements; i++, rightEnd--)
            {
                a[rightEnd] = tmpArray[rightEnd];
            }

            //List<int> list = a.OfType<int>().ToList();
        }
    }
}
