using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("John Smith", "My First Video", 600);
        Video video2 = new Video("Jane Doe", "Cooking 101", 900);

        video1.AddComment(new Comment("Alice", "Nice video"));
        video1.AddComment(new Comment("Bob", "Thanks for sharing"));

        video2.AddComment(new Comment("Jade", "Great recipe!"));
        video2.AddComment(new Comment("Olivia", "Yummy!"));

        var videos = new List<Video> { video1, video2 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSecs} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
                Console.WriteLine();
            }
        }
    }
}