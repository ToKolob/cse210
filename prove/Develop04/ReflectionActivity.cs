public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {
        InitializePrompts();
        InitializeQuestions();
    }

    private void InitializePrompts()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }

    private void InitializeQuestions()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        Random rand = new Random();

        // Select a random prompt
        string selectedPrompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(selectedPrompt);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        // Loop until activity duration is reached
        while (DateTime.Now < endTime)
        {
            Console.Clear();
            string selectedQuestion = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(selectedQuestion);
            ShowSpinner(15); // Pause for 15 seconds with spinner animation
        }

        DisplayEndMessage("Activity Completed!");
    }

    private void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            foreach (string symbol in spinner)
            {
                Console.Write($"\r{symbol} Thinking...");
                System.Threading.Thread.Sleep(250);
            }
        }
        Console.WriteLine();
    }
}

    

