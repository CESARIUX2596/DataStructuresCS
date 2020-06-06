using System;

namespace HeapSort
{
    class Program
    {
       static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 5, 3, 8,8,9,7,5,3,2,1,6,54,4,7,8,6,2,7,5,96,7,65,13,748,123,46,132,564,324,59,49 };
            int[] arr2 = new int[arr.Length];
            arr2 = HeapSort(arr);
            ArrayPrinter(arr);
        }
        public static void ArrayPrinter(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
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
    }
}