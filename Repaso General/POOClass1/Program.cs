using System;

namespace POOClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            int im_int; //Numeros enteros
            double im_double; //Numeros con punto decimal
            string im_string; // Cadenas de texto
            bool im_bool; // Valores verdadero o 
            DateTime im_date = DateTime.Now;
            //Hora en formato de 24 horas Formato( año, mes, dia, hora, minuto, segundo)
            DateTime date = new DateTime(2020, 5, 27, 15,0,0);
            //Console.WriteLine(date);

            im_int = 10;
            im_double = 1.1;
            im_string = "Soy una cadena";
            im_bool = true;

           

            int[] im_array_int = new int[] { 1,2,3}; // Lista de numeros enteros
            int[] arr2 = new int[] { 1, 2, 3, 4};
            string[] im_array_str = new string[4] {"hola", "Soy", "Un", "Aray"}; //Lista de cadenas de texto

            /*
            for (int i = 0; i < im_array_int.Length; i++)
            {
                Console.WriteLine("I vale: " + i);
                Console.WriteLine("Areglo 1 vale " + im_array_int[i]);
                //Actualizar posicion actual de un arreglo
                arr2[i] = im_array_int[i] + arr2[i];
                Console.WriteLine("Areglo 2 vale " + arr2[i]);
            }
            */

            //Crear arrelgo de tamaño fijo (25)
            int[] arr25 = new int[25];

            //Imprime el tamaño del arreglo
            //Console.WriteLine(arr25.Length);
            //Iterar el arreglo para asignarle valores

            for (int i = 0; i < arr25.Length; i++)
            {
                int valor = i;
                //asigna valor en posicion i
                arr25[i] = valor;
                //Imprime el valor asignado
                //Console.WriteLine(arr25[i]);
            }
            //Swap (Cambiar variables de posicion)

            //{1,2,3}
            /*
            int temp1, temp2;
            temp1 = im_array_int[1];  //{1,*2*,3}

            temp2 = im_array_int[2]; //{1,2,*3*}
            im_array_int[1] = temp2; //{1,3,3}
            im_array_int[2] = temp1; //{1,3,2}
            */

            //Invertir arreglo
            // {1,2,3,4}
            //{4,}
            //Creamos un arreglo del mismo tamaño al que vamos a invertir (arr2)
            int[] arr3 = new int[arr2.Length];
            //Variable para incrementar
            int k = 0;
            for (int i = arr2.Length-1; i >= 0; i--)
            {
                arr3[k] = arr2[i];
                Console.WriteLine(arr3[k]);
                k++;
            }

            //Arreglos multidimencionales

            int[,] arr2D = new int[4, 2] { { 1, 1 }, { 1, 2 }, { 2, 1 }, { 2, 2 }};

            int rowLen = arr2D.GetLength(0);
            int colLen = arr2D.GetLength(1);

            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    //Format imprime de manera fancy 
                    //Console.Write(string.Format("{0} ", arr2D[i, j]));
                    Console.Write(arr2D[i, j]);
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

        }
    }
}
