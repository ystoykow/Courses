namespace MergeSort
{
    using System;
    using System.Linq;

    public class Program
    {
       public static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            MergeSorting(arr,0,arr.Length-1);
            Console.WriteLine(string.Join(" ",arr));
        }

        public static void Merge(int[]arr, int start, int mid, int end)
        {
            int[] tempArr = new int[end - start + 1];
            int s = start;
            int m = mid + 1;
            int k = 0;
            while (s <= mid && m<=end)
            {
                if (arr[s] <= arr[m])
                {
                    tempArr[k] = arr[s];
                    k++;
                    s++;
                }
                else
                {
                    tempArr[k] = arr[m];
                    k++;
                    m++;
                }
            }

            while (s <= mid)
            {
                tempArr[k] = arr[s];
                k++;
                s++;
            }

            while (m <= end)
            {
                tempArr[k] = arr[m];
                k++;
                m++;
            }

            for (int i = start; i <= end; i++)
            {
                arr[i] = tempArr[i-start];
            }

        }

        public static void MergeSorting(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                MergeSorting(arr, start, mid);
                MergeSorting(arr, mid + 1, end);
                Merge(arr, start, mid, end);
            }
        }
    }
}
