using System;

namespace Lesson014_HT_Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            arr.SelectionSort();
            foreach (int el in arr)
                Console.Write(el + "  "); 
        }
    }
}
