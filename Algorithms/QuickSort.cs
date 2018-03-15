using System;
namespace Algorithms
{
    public class QuickSort
    {
        public void quicksortLomuto(int[] arr, int lo, int hi) 
        {
            Console.WriteLine("Entering LQS LO {0} HI {1}", lo, hi);
            if (lo < hi) 
            {
                var p = partitionLomuto(arr, lo, hi);
                Console.WriteLine("PIVOT {0}", p);
                quicksortLomuto(arr, lo, p - 1);
                quicksortLomuto(arr, p + 1, hi);
            } 
            foreach(int item in arr) 
            {
                Console.Write(" {0}", item);    
            }
            Console.WriteLine();
        }
        //F10 as "Step Over" or F11 as "Step Into" instead of F5("Go").
        private int partitionLomuto(int[] arr, int lo, int hi)  
        {
            var pivot = arr[hi];
            var i = lo - 1;
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
            Console.WriteLine("swapping position {0} with {1}", a, b);
            int temp = arr[a];
            arr[a] = b;
            arr[b] = temp;
        }
//            algorithm quicksort(A, lo, hi) is
//    if lo < hi then
//        p := partition(A, lo, hi)
//        quicksort(A, lo, p - 1)
//        quicksort(A, p + 1, hi)

//algorithm partition(A, lo, hi) is
    //pivot := A[hi]
    //i:= lo - 1
    //for j := lo to hi - 1 do
    //                if A[j] < pivot then
    //                    i := i + 1
    //        swap A[i] with A[j]
    //swap A[i + 1] with A[hi]
    //return i + 1
    }
}
