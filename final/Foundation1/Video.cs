public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        
    }

    public void AddComment(Comment comment)
    {
        
    }
    
    public int GetCommentCount()
    {
        
    }

    public List<Comment> GetComments()
    {
        
    }

    // Getters
    public string GetTitle() => _title;
    public string GetAuthor() => _author;
    public int GetLength() => _length;
}