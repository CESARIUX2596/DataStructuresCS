using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("The Sin and the Sentence", "Trivium", 350);
            Song s2 = new Song("Beyond Oblivion", "Trivium", 317);
            Song s3 = new Song("Other Worlds", "Trivium", 290);
            Song s4 = new Song("The Heart from Your Hate", "Trivium", 244);
            Song s5 = new Song("Betrayer", "Trivium", 327);
            Song s6 = new Song("The Wretchedness Inside", "Trivium", 332);
            Song s7 = new Song("Endless Night", "Trivium", 218);
            Song s8 = new Song("Server the Hand", "Trivium", 326);
            Song s9 = new Song("Beauty in the Sorrow", "Trivium", 271);
            Song s10 = new Song("The Revanchist", "Trivium", 437);
            Song s11 = new Song("Thrown into the Fire", "Trivium", 329);

            Queue<Song> q = new Queue<Song>(11);
            q.queue(s1);
            q.queue(s2);
            q.queue(s3);
            q.queue(s4);
            q.queue(s5);
            q.queue(s6);
            q.queue(s7);
            q.queue(s8);
            q.queue(s9);
            q.queue(s10);
            q.queue(s11);

            //Console.WriteLine(q.total);

            for (int i = 0; i < 11; i++)
            {
                Song currentSong = q.FrontValue();
                currentSong.PlaySong();
                Console.WriteLine(q.total);
                q.dequeue();
            }
        }
    }
}
