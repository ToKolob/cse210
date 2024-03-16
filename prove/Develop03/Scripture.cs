class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetReference());
        foreach (Word word in _words)
        {
            Console.Write(word.GetWord() + " ");
        }
        Console.WriteLine();
    }
    public bool IsAllHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public void HideRandomWords()
    {
        int scriptureLength = _words.Count;
        int fourHides = scriptureLength / 4 + 1;

        Random random = new Random();

        //The loop will hide 1/4 of the words, if the word is already hidden, it will hide the next word.        
        for (int i = 0; i < fourHides; i++)
        {
            if(this.IsAllHidden()){
                break;
            }
            int index = random.Next(0, scriptureLength);
            if (_words[index].IsHidden())
            {
                while (_words[index].IsHidden())
                {
                    index = random.Next(0, scriptureLength);
                }
                _words[index].Hide();
            }
            else
            {
                _words[index].Hide();
            }

            
            _words[index].Hide();
        }

    }
}