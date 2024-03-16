using System;

class Program
{
    static void Main(string[] args)
    {
        string quit = "";

        Console.WriteLine("Lets memorize scriptures!");
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

        while(quit != "quit"){

            Console.Clear(); 
            Console.WriteLine("Your scripture is:");
            newScripture.Display();

            if (newScripture.IsAllHidden()){
                Console.WriteLine("Congrats! You have memorized the entire scripture!");
                break;
            }
            Console.WriteLine("Press enter to hide words or type 'quit' to exit");
            quit = Console.ReadLine();
            if(quit == "quit"){
                break;
            }
            newScripture.HideRandomWords();


        
        }

    }
}