public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string description, int points) : base(goalName, description, points)
    {
        SetMoreDetails("Eternal");
    }    

    public override void IsCompleted()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
}

