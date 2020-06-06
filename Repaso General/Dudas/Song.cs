using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Dudas
{
    class Song
    {
        private string title, artist;
        private int length;
        /*
         *Get y Set nos permiten obtener y asignar valores que provienen de variables PRIVADAS
         */
        public string Title
        {
            get { return title; }
            set { title = Title; }
        }
        public string Artist
        {
            get { return artist; }
            set { artist = Artist; }
        }
        public int Length
        {
            get { return length; }
            set { length = Length; }
        }

        // Constructor de la Clase
        //Constructor que utiliza los metodos get y set que nosotros creamos
        
        public Song(string title, string artist, int length)
        {
            Title = title;
            Artist = artist;
            Length = length;
        }
        
        /*
         * Constructores equivalentes
         * this hace referencia a los parametros de la clase (variables privadas de arriba)
         * 
        public Song(string title, string artist, int length)
        {
            this.title = title;
            this.artist = artist;
            this.length = length;
        }
        */

        
    }
}
