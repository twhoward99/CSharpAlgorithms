using System;
using static System.Console;

namespace Algorithms
{
    public class QuickSort
    {
        public void QuicksortLomuto(int[] arr, int lo, int hi) 
        {
            if (lo < hi) 
            {
                var p = PartitionLomuto(arr, lo, hi);
                WriteLine("PIVOT {0}", p);
                QuicksortLomuto(arr, lo, p - 1);
                QuicksortLomuto(arr, p + 1, hi);
            } 
        }
        //F10 as "Step Over" or F11 as "Step Into" instead of F5("Go").
        private int PartitionLomuto(int[] arr, int lo, int hi)
        {
            int pivot = arr[hi];
            int i = lo - 1;
            for (int j = lo; j < hi; j++) 
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, hi);
            return i + 1;
        }

        private void swap(int[] arr, int a, int b)
        {
            WriteLine("swapping position {0} with {1}", a, b);
            int temp = arr[a];
            arr[a] = b;
            arr[b] = temp;
        }
    }
}
