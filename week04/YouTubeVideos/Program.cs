using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Tutorial for Beginners", "Programming Master", 1200);
        Video video2 = new Video("Learn Python in 1 Hour", "Code Wizard", 3600);
        Video video3 = new Video("Web Development Fundamentals", "Web Dev Pro", 2400);
        Video video4 = new Video("Data Structures Explained", "Algorithms Expert", 1800);

        // Add comments to video1
        video1.AddComment(new Comment("John Doe", "Great tutorial! Very helpful for beginners."));
        video1.AddComment(new Comment("Jane Smith", "I finally understand classes, thank you!"));
        video1.AddComment(new Comment("Mike Johnson", "Clear explanations and good examples."));
        video1.AddComment(new Comment("Sarah Wilson", "Could you make a video about inheritance?"));

        // Add comments to video2
        video2.AddComment(new Comment("Alice Brown", "Python is so much easier after watching this."));
        video2.AddComment(new Comment("Bob Davis", "Perfect pace for learning quickly."));
        video2.AddComment(new Comment("Charlie Miller", "Loved the practical examples!"));

        // Add comments to video3
        video3.AddComment(new Comment("David Lee", "Comprehensive overview of web development."));
        video3.AddComment(new Comment("Emily Chen", "The HTML/CSS section was particularly useful."));
        video3.AddComment(new Comment("Frank Harris", "When will you cover JavaScript frameworks?"));
        video3.AddComment(new Comment("Grace Taylor", "Well structured and easy to follow."));

        // Add comments to video4
        video4.AddComment(new Comment("Henry White", "Finally understand linked lists!"));
        video4.AddComment(new Comment("Ivy Martin", "The Big O notation explanation was crystal clear."));
        video4.AddComment(new Comment("Jack Anderson", "Great visualizations for complex concepts."));

        // Create list of videos
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display all videos and their comments
        Console.WriteLine("YouTube Video Analysis");
        Console.WriteLine("======================");
        Console.WriteLine();

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}