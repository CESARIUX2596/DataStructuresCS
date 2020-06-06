using System;
using System.ComponentModel.Design.Serialization;
using System.Linq;

namespace POOClass6
{
    enum WeekDay
    {
        /*
         * Enums son un mini objeto que agrega un valor numerico a su contenido
         */
        monday,         //0
        tuesday,        //1
        wednesday,      //2
        thursday,       //3
        friday,         //4
        saturday,       //5
        sunday          //6
    }
    class Program
    {
        
        static void Main(string[] args)
        {
        	//polimorfismo y herencia

        	/*
        	* 	https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/classes-and-structs/polymorphism
        	*/
            Cheff cheff1 = new Cheff();
            ItalianCheff cheff2 = new ItalianCheff();
            cheff1.MakeSpecialDish();
            cheff2.MakeSpecialDish();

            var shapes = new List<Shape>
			{
			    new Rectangle(),
			    new Triangle(),
			    new Circle()
			};

			foreach (var shape in shapes)
			{
			    shape.Draw();
			}
            //Linq

            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.WriteLine("{0,1} ", num);
            }

            int[] nums = { 6, -2, 30, -3, 0, -8, 12, 7, 8, 9, 100 };
            // Query que obtiene valores positivos menores a 10

            var result =
                from nu in nums
                where nu > 0
                where nu < 10
                select nu;
            Console.WriteLine("Los numeros positivos menores a 10: ");

            //ejecuta el query

            foreach (int i in result)
            {
                Console.WriteLine(i + " ");
            }


            string[] names = new string[] { "Paco", "Pedro", "Pepe", "Pablo" };
            var r =
                from name in names
                where name != "Pablo"
                select name;
            foreach (string name in r)
            {
                Console.WriteLine(name);
            }
            
            //Enums
            int n = (int)WeekDay.friday;
            WeekDay myday = WeekDay.friday;
            Console.WriteLine(n + " Friday" );

            //JaggedAraray
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];

            /*
             *jaggedArray[`
             *            jaggedArray[0] = new int[5];
                          jaggedArray[1] = new int[4];
                          jaggedArray[2] = new int[2];
             *           ]
             */

            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };

            /*
             * jaggedArray[
             *              [1, 3, 5, 7, 9]
             *              [ 0, 2, 4, 6 ]
             *              [11, 22 ]
             *            ]
             */

            
        }
    }
}
