using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("ABC Video", "Jack Black", 260);
        video1.AddComment("Alpha", "Great video!");
        video1.AddComment("Bravo", "Made my day!.");
        video1.AddComment("Charlie", "Very informative!");

        Video video2 = new Video("1-10 Numbers", "Mary Poppins", 100);
        video2.AddComment("Delta", "Fun way to learn.");
        video2.AddComment("Echo", "My kids love this.");
        video2.AddComment("Foxtrot", "Go to 100!");

        videos.Add(video1);
        videos.Add(video2);
        
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}