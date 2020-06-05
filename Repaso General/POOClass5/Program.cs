using System;

namespace PooClass5
{
    class Program
    {
        static void Main(string[] args)
        {
            // PG, PG-13, R, NR

            Movie starwars = new Movie("New Hope", "George Lucas", "DOG");
            Person person1 = new Person("Cesar", 23, starwars);
            Person person2 = new Person("Ana", 13);
            bool isLegal = person1.Legal();
            bool isLegal2 = person2.Legal();
            Console.WriteLine(isLegal);
            Console.WriteLine(isLegal2);
            //person1.playfavoritesong();
        }
    }
}
