using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        YouTube youtube = new YouTube();

        // --- Video 1 ---
        Video video1 = new Video("Introduction to C#", "Wisdom", 15);
        video1.AddComment(new Comment("Emma", "Very helpful tutorial!"));
        video1.AddComment(new Comment("Dennis", "Clear and concise."));
        video1.AddComment(new Comment("Sarah", "Thanks for sharing."));
        video1.AddComment(new Comment("John", "Subscribed!"));
        youtube.AddVideo(video1);

        // --- Video 2 ---
        Video video2 = new Video("Object-Oriented Programming", "Wisdom", 25);
        video2.AddComment(new Comment("Michael", "This made classes click for me."));
        video2.AddComment(new Comment("Grace", "Loved the examples."));
        video2.AddComment(new Comment("David", "Great explanation of constructors."));
        video2.AddComment(new Comment("Chloe", "Awesome walkthrough!"));
        youtube.AddVideo(video2);

        // --- Video 3 ---
        Video video3 = new Video("Lists and Collections", "Wisdom", 18);
        video3.AddComment(new Comment("Daniel", "Lists make storing data so easy."));
        video3.AddComment(new Comment("Sophia", "Can you do a video on dictionaries next?"));
        video3.AddComment(new Comment("James", "Very practical code sample."));
        video3.AddComment(new Comment("Lily", "Super clear explanation."));
        youtube.AddVideo(video3);

        // --- Video 4 ---
        Video video4 = new Video("Building a Console App", "Wisdom", 30);
        video4.AddComment(new Comment("Ryan", "Best project tutorial yet!"));
        video4.AddComment(new Comment("Zoe", "Following along step by step."));
        video4.AddComment(new Comment("Ethan", "Clean code structure, thanks!"));
        video4.AddComment(new Comment("Mia", "Looking forward to the next part."));
        youtube.AddVideo(video4);

        // Display everything
        youtube.DisplayVideo();
            }
        }