using System;

class Program
{
    static void Main(string[] args)
    {
        Videos videos1 = new Videos();
        videos1._title = "The Future of AI: 2025 and Beyond";
        videos1._author = "Tech Visionary";
        videos1._videoDuration = 720;

        Videos videos2 = new Videos();
        videos2._title = "10-Minute Beginner Yoga Routine";
        videos2._author = "Yoga with Sarah";
        videos2._videoDuration = 600;

        Videos videos3 = new Videos();
        videos3._title = "How to Cook the Perfect Steak";
        videos3._author = "Chef Marcus";
        videos3._videoDuration =  934;

        videos1.AddComment(new Comment { _name = "User123", _commentText = "This was super insightful! Can't wait to see how AI shapes our lives." });
        videos1.AddComment(new Comment { _name = "TechFan45", _commentText = "Great video! But I think quantum computing will play a bigger role than mentioned." });
        videos1.AddComment(new Comment { _name = "AI_Lover99", _commentText = "Wow, I didn't realize AI was advancing this fast. Mind blown!" });

        videos2.AddComment(new Comment { _name = "Alice", _commentText = "This is exactly what I needed to start my mornings! Thanks!" });
        videos2.AddComment(new Comment { _name = "Vivian", _commentText = "Such a simple yet effective routine. Feeling refreshed already!" });
        videos2.AddComment(new Comment { _name = "ChillSeeker22", _commentText = "Can you make a version with relaxing music? That would be amazing!" });
 
        videos3.AddComment(new Comment { _name = "Samantha", _commentText = "Chef Marcus, you nailed it! But what's your take on reverse searing?" });
        videos3.AddComment(new Comment { _name = "BBQMaster", _commentText = "Tried this method, and it actually worked! Best steak I've ever made" });
        videos3.AddComment(new Comment { _name = "FoodieLover", _commentText = " appreciate the detailed steps! Can you do one for chicken next?" });

        List <Videos> videos = new List<Videos> { videos1, videos2, videos3};

        foreach (Videos video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine(); 
        }
        
    }
}