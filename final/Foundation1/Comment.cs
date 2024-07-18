class Comment
{
    private string _nameOfPerson;
    private string _textComment;
    public Comment(string name,string comment)
    {
        _nameOfPerson = name;
        _textComment = comment;
    }
    public void GetCommentDetails()
    {
        Console.WriteLine($"{this._nameOfPerson} : {this._textComment}");
    }
}