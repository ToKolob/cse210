class Scripture
{
    private Reference _reference;
    private string _words;
    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        _words = words;
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetReference());
        Console.WriteLine(_words);
        Console.WriteLine();
    }

    public void TestData()
    {
        Console.WriteLine("Type: " + _reference.GetTypeS());
        Console.WriteLine("Source: " + _reference.GetSource());
        Console.WriteLine("Scripture: " + _reference.GetReference());
        Console.WriteLine("Words: " + _words);
        Console.WriteLine("");
    }
    public string GetWords()
    {
        return _words;
    }

    public Reference GetReference()
    {
        return _reference;
    }
}