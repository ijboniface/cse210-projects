using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video(
            "Introduction to C# Programming",
            "Code Academy",
            540);

        video1.AddComment(new Comment("John", "Very informative!"));
        video1.AddComment(new Comment("Sarah", "This helped me a lot."));
        video1.AddComment(new Comment("Michael", "Great explanation."));
        video1.AddComment(new Comment("Grace", "Looking forward to more tutorials."));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video(
            "Object-Oriented Programming Explained",
            "Tech Master",
            720);

        video2.AddComment(new Comment("David", "Excellent examples."));
        video2.AddComment(new Comment("Lucy", "Now I understand abstraction."));
        video2.AddComment(new Comment("Daniel", "Very clear presentation."));
        video2.AddComment(new Comment("Sophia", "Thank you for this lesson."));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video(
            "Building Your First Console App",
            "Programming Hub",
            430);

        video3.AddComment(new Comment("James", "Easy to follow."));
        video3.AddComment(new Comment("Emily", "I successfully built mine!"));
        video3.AddComment(new Comment("Chris", "Please make an advanced version."));
        video3.AddComment(new Comment("Ella", "Fantastic tutorial."));

        videos.Add(video3);

        // Video 4
        Video video4 = new Video(
            "Understanding Lists in C#",
            "Learn Coding",
            610);

        video4.AddComment(new Comment("Nathan", "Exactly what I needed."));
        video4.AddComment(new Comment("Olivia", "Very practical examples."));
        video4.AddComment(new Comment("Henry", "Thanks for sharing."));
        video4.AddComment(new Comment("Ava", "This was really helpful."));

        videos.Add(video4);

        // Display videos
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine();

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}