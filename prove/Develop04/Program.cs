using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program! ");

        while (quit == false){
            Console.WriteLine("Please choose an activity: ");
            Console.WriteLine("1. Breathing Activity ");
            Console.WriteLine("2. Listing Activity ");  
            Console.WriteLine("3. Reflection Activity ");
            Console.WriteLine("4. Quit ");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1){
                BreathingActivity a = new BreathingActivity();
                a.Run();
            }
            else if (choice == 2){
                ListingActivity b = new ListingActivity();
                b.Run();
            }
            else if (choice == 3){
                ReflectionActivity c = new ReflectionActivity();
                c.Run();
            }
            else if (choice == 4){
                quit = true;
            }
        }
    }
}

    

