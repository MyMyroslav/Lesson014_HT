using System;
namespace Lesson014_HT_Task4
{
    static class SortByGrowthCl
    {
        static public void SelectionSort(this int[] arr)
        {
            int n = 10;
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
