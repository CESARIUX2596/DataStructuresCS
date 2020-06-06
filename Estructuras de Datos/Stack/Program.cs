using System;

namespace LinkedListExmpl
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            LinkedList list = new LinkedList();
            list.AddNode(20);
            list.AddNode(30);
            list.AddNode(40);
            list.AddNode(50);
            //list.PrintNodes();
            //list.FindNode(10);
            //list.FindNode(30);
            Console.WriteLine(list.Lengt);
            list.DeleteNode(20);
            list.PrintNodes();
            list.GetNode(-1);
            

            GenericLinkedList<int> list = new GenericLinkedList<int>();
            list.AddNode(20);
            list.AddNode(30);
            list.AddNode(40);
            list.AddNode(50);
            //list.PrintNodes();
            //list.FindNode(10);
            //list.FindNode(30);
            Console.WriteLine(list.Lenght);
            list.DeleteNode(20);
            list.PrintNodes();
            list.GetNode(20);
            */

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


            GenericLinkedList<Song> playlist = new GenericLinkedList<Song>();
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
            playlist.AddNode(song11);


            for (int i = 0; i < playlist.Lenght; i++)
            {
                Song currentSong = playlist.GetNode(i).Value;
                currentSong.PlaySong();
            }

        }
    }
}
