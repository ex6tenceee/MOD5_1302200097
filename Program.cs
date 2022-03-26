using System;

namespace modul5_1302200097
{


    static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("No Time To Die");
        video1.IncreaseplayCount(13);
        SayaTubeVideo video2 = new SayaTubeVideo("Spectre");
        video2.IncreaseplayCount(15);
        SayaTubeVideo video3 = new SayaTubeVideo("Skyfall");
        video3.IncreaseplayCount(17);
        SayaTubeVideo video4 = new SayaTubeVideo("Peaky Blinders");
        video4.IncreaseplayCount(13);
        SayaTubeVideo video5 = new SayaTubeVideo("Jakarta VS Everybody");
        video5.IncreaseplayCount(13);
        SayaTubeVideo video6 = new SayaTubeVideo("Casino Royale");
        video6.IncreaseplayCount(13);
        SayaTubeVideo video7 = new SayaTubeVideo("Descendant of the sun");
        video7.IncreaseplayCount(13);
        SayaTubeVideo video8 = new SayaTubeVideo("Meteor Garden");
        video8.IncreaseplayCount(13);
        SayaTubeVideo video9 = new SayaTubeVideo("AADC 2");
        video9.IncreaseplayCount(13);
        SayaTubeVideo video10 = new SayaTubeVideo("AADC 4");
        video10.IncreaseplayCount(13);

        SayaTubeUser profile1 = new SayaTubeUser("user1");
        SayaTubeUser profile2 = new SayaTubeUser("user2");

        profile1.addVideo(video1);
        profile1.addVideo(video2);
        profile1.addVideo(video3);
        profile1.addVideo(video4);
        profile1.addVideo(video5);
        profile1.addVideo(video6);
        profile1.addVideo(video7);
        profile1.addVideo(video8);
        profile1.addVideo(video9);
        profile1.addVideo(video10);
        profile1.addVideo(null);
        profile1.printAllvideoplayCount();



    }

    }
}



