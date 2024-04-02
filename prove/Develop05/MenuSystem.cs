public class MenuSystem
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int GetScore()
    {
        return _score;
    }
    public void SetScore(int score)
    {
        _score = score;
    }

    public void DisplayMenu()

    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Your current score is: " + GetScore());
            Console.WriteLine("Menu Options: \n 1. Create New Goal \n 2. View Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit");
            string option = Console.ReadLine();

            if (option == "1")
            {
                createNewGoal();
            }
            else if (option == "2")
            {
                ViewGoals();
            }
            else if (option == "3")
            {
                saveGoals();
            }
            else if (option == "4")
            {
                loadGoals();
            }
            else if (option == "5")
            {
                RecordEvent();
            }
            else if (option == "6")
            {
                quit = true;
                Console.WriteLine("Goodbye!");
            }
        }

    }

    public void  createNewGoal()
    {
        Console.WriteLine("The types of goals are: \n 1. Simple Goal \n 2. Checklist Goal \n 3. Eternal Goal");
        string goalType = Console.ReadLine();
        Console.WriteLine("What is the name of your goal?");
        string goalName = Console.ReadLine();
        Console.WriteLine("What is a description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());
        if (goalType == "1")
        {
            SimpleGoal newGoal = new SimpleGoal(goalName, description, points);
            _goals.Add(newGoal);
        }
        else if (goalType == "2")
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int timesToComplete = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonusPoints = int.Parse(Console.ReadLine());
            ChecklistGoal newGoal = new ChecklistGoal(goalName, description, points, timesToComplete, bonusPoints);
            _goals.Add(newGoal);
        }
        else
        {
            EternalGoal newGoal = new EternalGoal(goalName, description, points);
            _goals.Add(newGoal);
        }
    }
    public void ViewGoals()
    {
        Console.Clear();
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            goal.GetDetails();
        }
    }
    public void saveGoals()
    {
        Console.WriteLine("What is the filename? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(GetScore());
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.RetrieveData());
            }
        }
    }
    public void loadGoals()
    {
        Console.WriteLine("What is the filename? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            if (line.Contains("¬"))
            {
                string[] parts = line.Split("¬");
                if(parts[4] == "SimpleGoal")
                {
                    SimpleGoal newGoal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));
                    if (parts[3] == "True")
                    {
                        newGoal.SetCompleted();
                    }
                    _goals.Add(newGoal);
                }
                else if (parts[4] == "ChecklistGoal")
                {
                    ChecklistGoal newGoal = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[5]), int.Parse(parts[6]));
                    if (parts[3] == "True")
                    {
                        newGoal.SetCompleted();
                    }
                    _goals.Add(newGoal);
                }
                else
                {
                    EternalGoal newGoal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
                    if (parts[3] == "True")
                    {
                        newGoal.SetCompleted();
                    }
                    _goals.Add(newGoal);
                }
            }
            else {
                int score = int.Parse(line);
                SetScore(score);
            }
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish? ");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal)}: ");
            goal.GetDetails();
        }
        int goalIndex = int.Parse(Console.ReadLine());
        _goals[goalIndex].IsCompleted();
        int newScore = GetScore() + _goals[goalIndex].GetPoints();
        SetScore(newScore);
    }
}

