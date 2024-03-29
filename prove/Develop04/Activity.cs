public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.WriteLine();
    }
    public void DisplayEndMessage(string aditionalMessage = "")
    {
        Console.Clear();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}!");
        Console.WriteLine();
        Console.WriteLine(aditionalMessage);
    }
    public void ShowAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void ShowCountDown(int seconds, string mensage = "Get Ready...")
    {
        for (int i = seconds; i > 0; i--)
        {        
            Console.Clear();
            Console.WriteLine(mensage);
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int newDuration)
    {
        _duration = newDuration;
    }
}

    

