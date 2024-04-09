class Reference
{
    private string _type;
    private string _source;
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    public Reference(string type, string source, string book, int chapter, int startVerse, int endVerse)
    {
        _type = type;
        _source = source;
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = 0;
    }
    public String GetReference()
    {
        if(_endVerse == 0){
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else{
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
    public string GetTypeS()
    {
        return _type;
    }
    public string GetSource()
    {
        return _source;
    }
    
};
