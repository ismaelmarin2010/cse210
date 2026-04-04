using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        List<Video> listOfVideos = new List<Video>();

        Video video1 = new Video("Artemis II Launch Today!", "Everyday Astronaut", 3541);
        video1.AddComment("Ismael M.", "Amazing! Thanks for the transmission!");
        video1.AddComment("Ron Damon", "This is the day mankind makes history!");
        video1.AddComment("Pedro Picapiedras", "Not getting tired of watching!");
        listOfVideos.Add(video1);

        Video video2 = new Video("SpaceX Starship S35 Launch", "SpaceX Corp", 2597);
        video2.AddComment("Carlin Calvo", "It was good it did not explode!");
        video2.AddComment("Prince Charles III", "I wish I was American!");
        video2.AddComment("Lionel Messi", "Does anyone knows when is the next match?");
        listOfVideos.Add(video2);

        Video video3 = new Video("City on Mars", "Life and Science", 455);
        video3.AddComment("Car Loscal Vo", "This is a boring video.");
        video3.AddComment("Palta Hass", "Am I a fruit or a vegetal?");
        video3.AddComment("Calamardo", "Have you seen Bob lately?");
        listOfVideos.Add(video3);

        for (int i = 0; i < listOfVideos.Count; i++)
        {
            listOfVideos[i].DisplayVideo();
        }
    }
}