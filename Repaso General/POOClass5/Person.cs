using System;
using System.Collections.Generic;
using System.Text;

namespace PooClass5
{
    class Person
    {
        private string name;
        private int age;
        private Movie favoriteMovie;

        //Constructores;
        public Person(string aName, int aAge, Movie aFavoriteMovie)
        {
            Name = aName;
            Age = aAge;
            Movie = aFavoriteMovie;
        }
        public Person(string aName, int aAge)
        {
            Name = aName;
            Age = aAge;
            Console.WriteLine("I don't have a favorite movie");
        }

        public bool Legal()
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Movie Movie
        {
            get { return favoriteMovie; }
            set { favoriteMovie = value; }
        }
    }
}
