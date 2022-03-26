using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200097
{
    internal class SayaTubeUser
    {
        int id;
        List<SayaTubeVideo> uploadedVideos;
        String username;


        public SayaTubeUser(String profile)
        {
            this.Username = profile;
            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            uploadedVideo = new List<SayaTubeVideo>();
        }

        public void addVideo(SayaTubeVideo data)
        {
            uploadedVideo.Add(data);
        }

        public void printAllvideoplayCount()
        {

            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("username:" + username);
                Console.WriteLine("video:" + (i + 1) + ":" + uploadedVideos[i]);
            }

        }

        public void GetTotalVideoplayCount()
        {
            int dataplayCount = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                dataplayCount = dataplayCount + video.GetPlaycount();
            }
        }


    }
}
