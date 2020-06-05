using Microsoft.VisualBasic.CompilerServices;
using System;

namespace POOClass2
{
    class Program
    {
        static void Main(string[] args)
        {

            select:
            Console.WriteLine("Calculadora! \n");
            //Suma, Resta, Mult, Div
            Console.WriteLine("[1] Sumar \n" +
                              "[2] Restar \n" +
                              "[3] Multiplicar \n" +
                              "[4] Dividir \n" +
                              "[5] Sumar Arreglos \n");

            Console.Write("Elija una opcion: ");
            string input = Console.ReadLine();
            int opcion = esNumero(input);
            //Console.WriteLine("Elegiste " + numero);

            string input_a, input_b;
            int numero_a, numero_b;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Sumar");

                    Console.WriteLine("Ingresa el primer numero");
                    input_a = Console.ReadLine();
                    numero_a = esNumero(input_a);
                    Console.WriteLine("Ingresa el segundo numero");
                    input_b = Console.ReadLine();
                    numero_b = esNumero(input_b);
                    int suma = Sumar(numero_a, numero_b);
                    Console.WriteLine("El resultado es: " + suma);
                    break;             
                case 2:
                    Console.WriteLine("Restar");
                    Console.WriteLine("Ingresa el primer numero");
                    input_a = Console.ReadLine();
                    numero_a = esNumero(input_a);
                    Console.WriteLine("Ingresa el segundo numero");
                    input_b = Console.ReadLine();
                    numero_b = esNumero(input_b);
                    int resta = Restar(numero_a, numero_b);
                    Console.WriteLine("El resultado es: " + resta);
                    break;
                case 3:
                    Console.WriteLine("Multiplicar");
                    Console.WriteLine("Ingresa el primer numero");
                    input_a = Console.ReadLine();
                    numero_a = esNumero(input_a);
                    Console.WriteLine("Ingresa el segundo numero");
                    input_b = Console.ReadLine();
                    numero_b = esNumero(input_b);
                    int multiplicacion = Multiplicar(numero_a, numero_b);
                    Console.WriteLine("El resultado es: " + multiplicacion);
                    break;
                case 4:
                    Console.WriteLine("Dividir");
                    Console.WriteLine("Ingresa el primer numero");
                    input_a = Console.ReadLine();
                    numero_a = esNumero(input_a);
                    elegir:
                    Console.WriteLine("Ingresa el segundo numero");
                    input_b = Console.ReadLine();
                    numero_b = esNumero(input_b);
                    if (numero_b == 0)
                    {
                        Console.WriteLine("No es posible dividir sobre 0, elije otro numero ");
                        goto elegir;
                    }
                    double divicion = Dividir(numero_a, numero_b);
                    Console.WriteLine("El resultado es: " + divicion);
                    break;
                case 5:
                    Console.WriteLine("Sumar Arreglos");
                    int[] arr = new int[100];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = i + 100;
                    }
                    int sumaArr = sumarArreglos(arr);
                    Console.WriteLine("El resultado es: " + sumaArr);

                    break;

                default:
                    goto select;
            }


        }

        public static int sumarArreglos(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            return total;
        }
        public static int esNumero(string input)
        {
            int number;
            // Si puedes traducir a entero regresame el numero
            if (int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("No se ingreso un numero, intente de nuevo");
            }
            bool isDigit = false;   
            while (isDigit == false)
            {
                Console.WriteLine("Porfavor Ingrese un numero: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    isDigit = true;
                    return number;
                }
                else
                {
                    Console.WriteLine("No se ingreso un numero, intente de nuevo");
                }
            }
            return 0;
            
        } 
        public static int Sumar(int a, int b)
        {
            int resultado;
            resultado = a + b;
            return resultado;
        }
        public static int Restar(int a, int b)
        {
            int resultado;
            resultado = a - b;
            return resultado;
        }
        public static int Multiplicar(int a, int b)
        {
            int resultado;
            resultado = a * b;
            return resultado;
        }
        public static double Dividir(int a, int b)
        {
            double resultado;
            resultado = (double)a / b;
            return resultado;
        }
    }
}
