using System;
using static System.Console;
                   
namespace Algorithms
{
    public class WriteUtils
    {
        public static void WriteIntArray(int[] arr) 
        {
            foreach (int item in arr)
            {
                Write(" {0}", item);
            }
            WriteLine("");
        }
    }
}
