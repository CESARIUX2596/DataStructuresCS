using System;
using System.ComponentModel;
using System.Drawing;

namespace POOClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi(4, "A", "B", "C");
        }
        public static void Move(string f, string t)
        {
            Console.WriteLine("Move disc from {0} to {1}!", f, t);
        }
        public static void MoveVia(string f, string v, string t)
        {
            Move(f, v);
            Move(v, t);
        }
        public static void Hanoi(int n, string f, string h, string t)
        {
            if (n == 0)
                { }
            else
            {
                Hanoi(n - 1, f, t, h);
                Move(f, t);
                Hanoi(n - 1, h, f, t);
            }
        }
        public static int Factorial(int target)
        {
            if (target == 1)
                return 1;
            else
            {
                return target * Factorial(target - 1); 
            }

        }
        public static int Fibonacci(int target)
        {

            if (target == 0 || target == 1)
            {
                return target;
            }
            int total = 1;
            int previous = 1;
            for (int i = 2; i < target; i++)
            {
                int temp = total;
                total += previous;
                previous = temp;
            }
            return total;
        }
        public static int FibonacciRecursive(int target)
        {
            if(target == 0 || target == 1)
            {
                return target;
            }
            else
            {
                return FibonacciRecursive(target - 1) + FibonacciRecursive(target - 2);
            }
            
        }
        public static string Cadena()
        {
            string Hw = "Soy un msg";
            return Hw;
        }
        static void HolaMundo(string msg)
        {
            Console.WriteLine("Hola, Mundo Void");
            Console.WriteLine(msg);   
        }

        public static int[] CreaArreglos(int size)
        {
            int min = -10000; ;
            int max = 10000;
            int[] arr = new int[size]; 
            Random ran = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = ran.Next(min, max);
            }
            return arr;
            
        }
        public static void ImprimeArreglos(int[] a) //tipo void no espera que regresemos ningun valor (return variable;)
        {
            int size = a.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
