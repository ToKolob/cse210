public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _timesToComplete;
    private int _timesDone;

    public ChecklistGoal(string goalName, string description, int points, int timesToComplete, int bonusPoints) : base(goalName, description, points)
    {
        _bonusPoints = bonusPoints;
        _timesToComplete = timesToComplete;
        _timesDone = 0;
        SetMoreDetails("Checklist¬"+timesToComplete+"¬"+_timesDone+"¬"+bonusPoints);
    }

    public override void IsCompleted()
    {
        if (_timesDone == _timesToComplete)
        {
            SetCompleted();
            SetMoreDetails("Checklist¬"+_timesToComplete+"¬"+_timesDone+"¬"+_bonusPoints);
            Console.WriteLine($"Congratulations! You have earned {_bonusPoints + GetPoints()} points!");
        }
        else
        {
            _timesDone++;
            SetMoreDetails("Checklist¬"+_timesToComplete+"¬"+_timesDone+"¬"+_bonusPoints);
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
            Console.WriteLine($"You have accomplished {_timesDone} out of {_timesToComplete} goals!");
        }
    }
}

