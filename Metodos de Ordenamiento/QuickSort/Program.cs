using System;

namespace QuickSort
{
    class Program
    {
       static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 5, 3, 8,8,9,7,5,3,2,1,6,54,4,7,8,6,2,7,5,96,7,65,13,748,123,46,132,564,324,59,49 };
            int[] arr2 = new int[arr.Length];
            arr2 = QuickSort(arr);
            ArrayPrinter(arr);
        }
        }
        public static void ArrayPrinter(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static int[] QuickSort(int[] arr)
        {
            arr = QuickSort(arr, 0, arr.Length - 1);
            return arr;
        }
        private static int[] QuickSort(int[] arr, int first, int last)
        {
            if (last > first)
            {
                int pivot = Partition(arr, first, last);
                arr = QuickSort(arr, first, pivot - 1pivot - 1);
                arr =QuickSort(arr, pivot + 1, last);
            }
            return arr;
        }
        private static int Partition(int[] arr, int first, int last)
        {
            int pivot = arr[first];
            int low = first + 1;
            int high = last;

            while (high > low)
            {
                while (low <= high && arr[low] <= pivot)
                    low++;
                while (low <= high && arr[high] > pivot)
                    high--;
                if (high > low)
                {
                    int temp = arr[high];
                    arr[high] = arr[low];
                    arr[low] = temp;
                }
            }

            while (high > first && arr[high] >= pivot)
                high--;

            if (pivot > arr[high])
            {
                arr[first] = arr[high];
                arr[high] = pivot;
                return high;
            }
            else
            {
                return first;
            }
        }
    }
}