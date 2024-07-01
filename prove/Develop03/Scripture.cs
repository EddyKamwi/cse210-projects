class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        foreach (var item in text.Split(" "))
        {
            _words.Add(new(item));
        }

    }
    public void HideRandomWords(int numberToHide)
    {
        int num = numberToHide;
        // iterating for the given num of time in the parameter
        for (int i = 0; i < num; i++)
        {
            Random random = new Random();

            //loop to check if the number selected is not hidden
            while (true)
            {
                // random select number
                int index = random.Next(_words.Count);

                //check if is not hidden
                if (!IsPlaceholder(_words[index].ToString()))
                {
                    int lenth = _words[index].ToString().Length;
                    string placeholder = new String('_', lenth);
                    _words[index] = new Word(placeholder);
                    break;
                }
            }

        }
    }
    public string GetDisplayText()
    {
        string textDisplay = $"{_reference.GetDisplayText()} {String.Join(" ", _words)}";
        return textDisplay;
    }
    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!IsPlaceholder(word.ToString()))
            {
                return false;
            }

        }
        return true;
    }
    static bool IsPlaceholder(string word)
    {
        foreach (char letter in word)
        {
            if (letter != '_')
            {
                return false;
            }
        }
        return true;
    }
}
