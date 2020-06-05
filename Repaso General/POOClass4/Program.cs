using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace POOClass4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 5, 3, 8,8,9,7,5,3,2,1,6,54,4,7,8,6,2,7,5,96,7,65,13,748,123,46,132,564,324,59,49 };
            int[] arr2 = new int[arr.Length];
            //arr2 = BubbleSort(arr);
            //arr2 = QuickSort(arr);
            //arr2 = HeapSort(arr);
            arr2 = MergeSort(arr);
            ArrayPrinter(arr);
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
        public static int [] HeapSort(int[] arr)
        {
            int n = arr.Length;

            // Crear el Heap (arbol) 
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            // Iterar el arbol para obtener los elementos
            for (int i = n - 1; i > 0; i--)
            {
                // Mover la raiz (numero mayor) al final del arreglo
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                //Reducir el Heap
                Heapify(arr, i, 0);

            }
            return arr;
        }
        public static void Heapify(int[] arr, int n, int i)
        {
            int largest = i; // Inicializar el valor mas grande como la raiz
            int l = 2 * i + 1; // Hijo izquieda = 2*i + 1 
            int r = 2 * i + 2; // Hijo derecha = 2*i + 2 Formula para encontrar al hijo derecha
                                // Arbol binario siempre tiene dos hijos 

            // Revisar si hijo izquierda es mas grande que la raiz
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // Revisar si hijo derecha es mas grande que el numero mas grand que tenemso 
            if (r < n && arr[r] > arr[largest])
                largest = r;
            
            // Verificar si  el numero mas grande no es la raiz
            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;
                // Recursividad para hacer hacerlo con el subarbol
                Heapify(arr, n, largest);
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
        public static void ArrayPrinter(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void torresHanoi(int n) 
        {
            torresHanoi(n, "A", "B", "C");
        }
        private static void torresHanoi(int n, string torre1, string torre2, string torre3)
        {
            if (n > 0)
            {
                torresHanoi(n - 1, torre1, torre3, torre2);
                
                Console.Write("\nSe mueve anillo " + n + " desde torre " + torre1 + " hasta torre " + torre3);
                torresHanoi(n - 1, torre2, torre1, torre3);
            }
        }
    }
}
