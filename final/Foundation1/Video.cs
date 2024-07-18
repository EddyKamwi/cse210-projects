class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length,List<Comment> comments)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
        _comments = comments;
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public void GetVideoDetails()
    {
        Console.WriteLine($"\nTitle: {this._title}, Author: {this._author}, Length: {this._lengthInSeconds}seconds, Number of comments({this.GetNumberOfComments()})\n"+
        "Comments:");
        foreach (Comment comment in _comments)
        {
            comment.GetCommentDetails();
        }
    }
}