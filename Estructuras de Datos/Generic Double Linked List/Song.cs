using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedListGeneric
{
    class Song
    {
        private string title;
        private string artist;
        private int lenght;
        public Song(string title, string artist, int lenght)
        {
            Title = title;
            Artist = artist;
            Lenght = lenght;
        }
        public void PlaySong()
        {
            Console.WriteLine("Playing {0} by {1}", title, artist);
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        public int Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }
    }
}
