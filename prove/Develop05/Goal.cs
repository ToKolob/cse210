public class Goal
{
    public string _goalName;
    private string _description;
    private int _points;
    private bool _completed;
    private string _moreDetails;

    public Goal(string goalName, string description, int points)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
        _completed = false;
    }
    public int GetPoints()
    {
        return _points;
    }

    public void GetDetails()
    {
        if (_completed)
        {
            Console.WriteLine($"[X] {_description} ({_points} points)");
        }
        else
        {
            Console.WriteLine($"[ ] {_description} ({_points} points)");
        }                
    }
    public string RetrieveData ()
    {
        return $"{_goalName}¬{_description}¬{_points}¬{_completed}¬{_moreDetails}";
    }
    public void SetCompleted()
    {
        _completed = true;
    }
    public void SetMoreDetails(string moreDetails)
    {
        _moreDetails = moreDetails;
    }
    public virtual void IsCompleted()
    {
        SetCompleted();
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
}

