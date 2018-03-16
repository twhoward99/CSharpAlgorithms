using System;

namespace Algorithms
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var quickSort = new QuickSort();
            int[] jumbledArray = { 1, 5, 73, 90, 11, 43, 10 };
            quickSort.QuicksortLomuto(jumbledArray, 0, jumbledArray.Length - 1);
        }
    }
}
