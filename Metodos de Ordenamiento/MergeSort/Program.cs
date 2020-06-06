using System;

namespace MergeSort
{
    class Program
    {
       static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 5, 3, 8,8,9,7,5,3,2,1,6,54,4,7,8,6,2,7,5,96,7,65,13,748,123,46,132,564,324,59,49 };
            int[] arr2 = new int[arr.Length];
            arr2 = MergeSort(arr);
            ArrayPrinter(arr);
        }
        public static void ArrayPrinter(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static int[] MergeSort(int[] arr)
        {
            MergeSort(arr, 0, arr.Length - 1);
            return arr;
        }
        private static int[] MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Same as (l+r)/2, but avoids overflow for 
                // large l and h 
                int m = l + (r - l) / 2;

                // sorteamos ambas mitades del arr
                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);

                Merge(arr, l, m, r);
            }
            return arr;
        }
        private static void Merge(int[] arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            //Creamos arreglos temporales
            int[] lArr = new int[n1];
            int[] rArr = new int[n2];


            // Copiamos los nueros a arrays temporales lArr[] y rArr[]
            for (i = 0; i < n1; i++)
                lArr[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                rArr[j] = arr[m + 1 + j];

            //unimos los arregos temporales
            i = 0; // indice inicial array 1
            j = 0; // indice inicial array 2
            k = l; // indice inicial array combinado
            while (i < n1 && j < n2)
            {
                if (lArr[i] <= rArr[j])
                {
                    arr[k] = lArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rArr[j];
                    j++;
                }
                k++;
            }

            // Copiamos los datos que queden de lArr si es que queda alguno
            while (i < n1)
            {
                arr[k] = lArr[i];
                i++;
                k++;
            }

            // Copiamos los datos que queden de rArr si es que queda alguno
            while (j < n2)
            {
                arr[k] = rArr[j];
                j++;
                k++;
            }
        }    
    }
}