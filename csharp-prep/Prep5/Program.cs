using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int number;
        static void DisplayMessage()
        {
            Console.WriteLine("Melcome to the program!");
        }
        
        DisplayMessage();
        name = PronptUserName();
        number = PromptUserNumber();
        DisplayResult(name, number);           

    }
        static string PronptUserName(){
        Console.WriteLine("What is your name?");            
        return Console.ReadLine();
    }

    static int PromptUserNumber(){
        Console.WriteLine("What is your favorite number?");
        return int.Parse(Console.ReadLine());
    }
    static float SquareNumber(int number){
        return number * number;
    }
    static void DisplayResult(string name, int number){
        float square = SquareNumber(number);
        Console.WriteLine($"{name}, the square of {number} your number is {square}");
    }
}