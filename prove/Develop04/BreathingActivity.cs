public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
    }
    public void incriseDuration(int seconds){
        int newDuration = GetDuration() + seconds;
        SetDuration(newDuration);
    }
    public void Run(){
        DisplayStartMessage();
        ShowAnimation(5);
        string stop = "";
        int breathDuration = 4;
        while (stop == "")
        {
            ShowCountDown(breathDuration, "Breath in...");
            ShowCountDown(breathDuration,"Now breathe out...");
            incriseDuration(breathDuration*2);
            breathDuration++;
            Console.Clear();
            Console.WriteLine("Press any key to quit or enter to continue breathing even deeper....");
            stop = Console.ReadLine();
        }
        DisplayEndMessage();
    }
}

    

