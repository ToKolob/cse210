using System;

class Program
{
    static void Main(string[] args)
    {
        string quit = "";

        Console.WriteLine("Lets memorize scriptures!");

        while(quit != "quit"){
            Console.WriteLine("Enter book:");
            string book = Console.ReadLine();
            Console.WriteLine("Enter chapter:");
            int chapter = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter start verse:");
            int startVerse = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end verse:");
            int endVerse = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the scripture text:");
            string text = Console.ReadLine();
            Reference reference = new Reference(book, chapter, startVerse, endVerse);

            List<Word> words = new List<Word>();
            string[] wordsArr = text.Split(" ");
            foreach(string word in wordsArr){
                Word newWord = new Word(word);
                words.Add(newWord);
            }

            Scripture newScripture = new Scripture(reference, words);
            Console.WriteLine("Your scripture is:");
            newScripture.Display();
            Console.WriteLine("Press enter to hide words or type quit to exit");
            quit = Console.ReadLine();
            if(quit == "quit"){
                break;
            }
            newScripture.HideWords();


        
        }

    }
}

class Word{    
    private string _word;
    private bool _hidden;

    public Word(string word, bool hidden)
    {
        _word = word;
        _hidden = hidden;
    }
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public void Hide(){
        _hidden = true;
    }
    public void Show(){
        _hidden = false;
    }
    public string GetWord(){
        if(_hidden){
            string hiddenWord = "";
            for(int i = 0; i < _word.Length; i++){
                hiddenWord += "_";
            }
            return hiddenWord;
        }
        else{
            return _word;
        }
    }
    public bool IsHidden(){
        return _hidden;
    }

}
class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
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
    
};
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
        Random random = new Random();
        
        for (int i = 0; i < 3; i++)
        {
            int index = random.Next(0, scriptureLength);
            _words[index].Hide();
        }

    }
}