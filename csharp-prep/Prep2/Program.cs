using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("inset the percentage of the student exame score:");
        string input = Console.ReadLine();
        double percentage = double.Parse(input);

        string letter;

        if (percentage >= 90)
        {
             letter = "A";
        }
        else if (percentage >= 80)
        {
             letter = "B";
        }
        else if (percentage >= 70)
        {
             letter = "C";
        }
        else if (percentage >= 60)
        {
             letter = "D";
        }
        else 
        {
             letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");



        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed the class.");
        }
    }
}