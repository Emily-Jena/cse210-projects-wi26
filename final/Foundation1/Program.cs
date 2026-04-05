using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();

        //Video 1-3 Display - title, author, length - added comments, name, comment
        Video v1 = new Video("Walk With Me", "Jensen Diederich", 550);
        v1.AddComment(new Comment("Elissandro", "So grateful to be apart of this song! Thank you Strive to Be"));
        v1.AddComment(new Comment("Niv", "FSY2026 🔥 Here we go💪🏾"));
        v1.AddComment(new Comment("Jacari", "Just listening this after I had a dream walking with Him ❤"));
        v1.AddComment(new Comment("Azekiel", "So beautiful I love the song❤"));
        videos.Add(v1);

        Video v2 = new Video("Pillar of Light", "Grant Lemon and Hallie Taylor", 2400);
        v2.AddComment(new Comment("Jullian", "I love when they say 'to place a little piece of heaven  here'  I never really thought about the priesthood in thar light.  Thank you for that!"));
        v2.AddComment(new Comment("Sina", "Grant and Hallie's voices combine so well, I feel the Spirit so strong every time I listen to this song! Thank you Nik Day and to all the performers!"));
        v2.AddComment(new Comment("Saleha", "Sounds good as a duo"));
        videos.Add(v2);

        Video v3 = new Video("Festival: A Youth Concert 2024", "Strive to Be", 60000);
        v3.AddComment(new Comment("Strive to Be", "Which part of the concert brought you the most joy?"));
        v3.AddComment(new Comment("Mikaylee", "i am so exitied for the next festival (i am going to be at fsy but i hope i can still see it)"));
        v3.AddComment(new Comment("Decklan", "I have been following you from West Africa( côte d'ivoire) i love this song. I love Connor"));
        v3.AddComment(new Comment("Eris", "Thank you infiniment I can feel our Savior's love I am so grateful for Repentance and the Atonement of Christ"));
        v3.AddComment(new Comment("Joe", "Is it ok to be 36 and enjoy this music? This concert gave me goosebumps and tears. THANK YOU"));
        videos.Add(v3);


        //Display All Videos
        foreach (Video vid in videos)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Title: {vid.GetTitle()}");
            Console.WriteLine($"Author: {vid.GetAuthor()}");
            Console.WriteLine($"Length: {vid.GetLength()} seconds");
            Console.WriteLine($"Total Comments: {vid.GetCommentCount()}");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
        
            Console.WriteLine($"\n The comments are:");

            foreach (Comment com in vid.GetComments())
            {
                Console.WriteLine($"- {com.GetName()}: ~'{com.GetText()}");
            }

            Console.WriteLine("----------------------------------------------");
        
        }
    }
}