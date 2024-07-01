class Word
{
    private string _text;
    private bool _isHidden;

    //to help me convert string to word
    public string Text
    {
        get; set;
    }
    public override string ToString()
    {
        return Text;
    }

    public Word(string text)
    {
        _text = text;

        // this is also part of helping me covert string to word
        Text = text;
    }
    public void Hide()
    {

    }
    public void Show()
    {

    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}