public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        Random rand = new Random();
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        string selectedPrompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(selectedPrompt);

        ShowCountDown(5); // Countdown for 5 seconds

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item (or type 'done' to finish): ");
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
                break;
            
            _prompts.Add(input);
        }

        DisplayEndMessage($"Number of items listed: {_prompts.Count}");
    }
}

    

