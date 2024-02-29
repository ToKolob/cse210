using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = 0;
        string guessAux;

        Console.WriteLine($"The magic number is {magicNumber}");

        while (guess != magicNumber){
            Console.WriteLine("What is your guess? ");
            guessAux = Console.ReadLine();
            guess = int.Parse(guessAux);

            if (guess > magicNumber){
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber){
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You guessed it!");
    }
}