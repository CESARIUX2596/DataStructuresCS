using System;

namespace DoubleLinkedListGeneric
{
 
    class Program
    {
        static void Main(string[] args)
        {

            Song song1 = new Song("The Sin and the Sentence", "Trivium", 350);
            Song song2 = new Song("Beyond Oblivion", "Trivium", 317);
            Song song3 = new Song("Other Worlds", "Trivium", 290);
            Song song4 = new Song("The Heart from Your Hate", "Trivium", 244);
            Song song5 = new Song("Betrayer", "Trivium", 327);
            Song song6 = new Song("The Wretchedness Inside", "Trivium", 332);
            Song song7 = new Song("Endless Night", "Trivium", 218);
            Song song8 = new Song("Server the Hand", "Trivium", 326);
            Song song9 = new Song("Beauty in the Sorrow", "Trivium", 271);
            Song song10 = new Song("The Revanchist", "Trivium", 437);
            Song song11 = new Song("Thrown into the Fire", "Trivium", 329);


            GenericDoubleLinkedList<Song> playlist = new GenericDoubleLinkedList<Song>();
            playlist.AddNode(song1);
            playlist.AddNode(song2);
            playlist.AddNode(song3);
            playlist.AddNode(song4);
            playlist.AddNode(song5);
            playlist.AddNode(song6);
            playlist.AddNode(song7);
            playlist.AddNode(song8);
            playlist.AddNode(song9);
            playlist.AddNode(song10);
            playlist.Push(song11);

            /*
            Song currentSong = playlist.GetNode(0).Next.Val;
            Console.WriteLine(currentSong.Title);
            Song currentSong2 = playlist.GetNode(1).Prev.Val;
            Console.WriteLine(currentSong2.Title);
            //playlist.Pop();
            //Console.WriteLine(playlist.Lenght);
            //playlist.AddNode(song11);
            */

            bool status = true;
            int cntActual = 0;
            while (status == true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    status = !status;
                }
                else
                {
                    if (input == "play")
                    {
                        // PlaySong() de playlist en pos cntActual

                    }
                    else if (input == "next")
                    {
                        //play next del cnt actual
                        // incrementar cntActual y

                    }
                    else if (input == "prev")
                    {
                        //play prev del cnt actual
                        // decrementar cntActual y dar play

                    }
                }
            }
        }
    }
}
