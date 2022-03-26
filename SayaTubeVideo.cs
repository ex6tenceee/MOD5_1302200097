using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200097
{
    internal class SayaTubeVideo
    {
        int id;
        String title;
        int playCount;

        public SayaTubeVideo(String JudulVideo)
        {
            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            this.playCount = 0;

        }

        public static void IncreasePlayCount(int Angka, int playCount)
        {
            playCount = playCount + Angka;
        }

        public int GetPlaycount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }

        public static void PrintVideoDetails(int id, String title, int playCount)
        {
            Console.WriteLine("ID Film : " + id + "Dengan judul film : " + title + playCount);
        }



    }
}
