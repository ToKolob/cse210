public class SimpleGoal : Goal
{

    public SimpleGoal(string goalName, string description, int points) : base(goalName, description, points)
    {
        SetMoreDetails("Simple");
    }
}

