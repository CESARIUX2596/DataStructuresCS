using System;

namespace BubbleSort
{
    class Program
    {
       static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 5, 3, 8,8,9,7,5,3,2,1,6,54,4,7,8,6,2,7,5,96,7,65,13,748,123,46,132,564,324,59,49 };
            int[] arr2 = new int[arr.Length];
            arr2 = BubbleSort(arr);
            ArrayPrinter(arr);
        }
        public static void ArrayPrinter(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static int[] BubbleSort(int[] arr)
        {
            //Cambias por tuplas mandando el valor mas grande a la derecha 
            // Iteras hasta que ya no puedas hacer cambios
            /*
            //BubbleSort Con Whiles
            bool swaps;
            do
            {
                swaps = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swaps = true;
                        ArrayPrinter(arr);
                        Console.WriteLine("\n");
                    }
                }
            } while (swaps);
            */

            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
