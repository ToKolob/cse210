using System;
using System.Diagnostics;
using System.Formats.Asn1;
using System.IO;

partial class Program
{
    static void Main(string[] args)
    {
        //instantiating the class promptGenerator
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator._prompts.Add("Who was the most interesting person I interacted with today?");
        promptGenerator._prompts.Add("What was the best part of my day?");
        promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today?");
        promptGenerator._prompts.Add("What was the strongest emotion I felt today?");

        //instantiating the class Journal
        Journal journal = new Journal();

        //DateTime now
        DateTime theDate = DateTime.Now;
        string date = theDate.ToString("MM/dd/yyyy");

        


        
        Console.WriteLine("Welcome to the Journal Program!");
        string answer = "";
        while (answer != "5"){
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            answer = Console.ReadLine();
            Console.WriteLine();

            switch(answer){
                case "1":                    
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string entry = Console.ReadLine();
                    Console.WriteLine();
                    

                    Entry newEntry = new Entry();
                    newEntry._promptText = prompt;
                    newEntry._entryText = entry;
                    newEntry._date = date;

                    journal.Add(newEntry);

                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    journal.ReadText();
                    Console.WriteLine("Loaded!");
                    break;

                case "4":
                    Console.WriteLine("Saving...");
                    journal.WriteText();
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    break;

            }



        }
    }
}