using System;
using System.Collections.Generic;
using System.Text;

namespace PooClass5
{
    class Movie
    {
        private string title;
        private string director;
        private string rating;

        public Movie()
        {

        }
        public Movie(string aTitle, string aDirector, string aRating)
        {
            Title = aTitle;
            Director = aDirector;
            Rating = aRating;
        }
        public void Play()
        {
            Console.WriteLine("Playing " + title);
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Rating
        {
            get { return rating; }
            set
            {
                if(value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value; 
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
