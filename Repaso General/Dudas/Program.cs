using System;
using System.Xml.Schema;

namespace Dudas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * SWAPS
             * Cambiar elementos  dentro del arreglo
             * Cambiar las orillas
             */
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //Imprimir antes de cambio
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(" ");
            int tmp = arr[0];
            arr[0] = arr[arr.Length - 1];// Equivalente a arr[4]
            // { 5, 2, 3, 4, 5 };
            arr[arr.Length - 1] = tmp;
            // { 5, 2, 3, 4, 1 };
            //Imprimir despues del cambio
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            /*
             * Rersion
             */

            int tope = 10;
            int total = 0;
            total = sumatoria(tope);
            Console.WriteLine(total);

        }
        //Metodos siempre van fuera del Main()
        public static int sumatoria(int tope)
        {
            int total = sumatoria(0, tope);
            return total;
        }
        private static int sumatoria (int total, int tope)
        {
            if(total == tope)
            {
                return total;
            }
            else if (total < tope)
            {
                total = sumatoria(total + 1, tope);
            }
            return total;
        }
    }
}
