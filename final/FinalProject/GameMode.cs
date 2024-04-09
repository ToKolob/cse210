
//base class
class GameMode
{
    private int _pointsPerQuestion = 20;
    private int _acumulatePoints = 0;
    private int _rightAnswersCounter = 0;
    private List<Scripture> _scriptures = new List<Scripture>();
    public GameMode(List<Scripture> scriptures)
    {
        _scriptures = scriptures;
    }

    public virtual void StartGame()
    {
        StartMensage();
        for (int i = 0; i < 5; i++)
        {
            DisplayQuestion();
        }        
    }
     
    public virtual void StartMensage()
    {
        Console.Clear();
        Console.WriteLine("Get ready to dive into the challenge! The game mode is starting now. Have fun!");
        Console.WriteLine("");
        Console.WriteLine("In this Mode each question you answer will earn you " + _pointsPerQuestion + " points. Good luck!");
        DisplayAnimation();
    }
    public void DisplayAnimation()
    {
        Console.WriteLine("Get ready to answer the question!");
        Console.WriteLine();

        // Person jumping animation frames
        string[] personFrames = new string[]
        {
            @"
Get ready to answer the question!

  O
 /|\
 / \
",

            @"
Get ready to answer the question!
 \O/
  |
 / \

",

            @"
Get ready to answer the question!

  O
 /|\
 / \
",

            @"
Get ready to answer the question!
 \O/
  |
 / \

"
        };

        // Loop through frames
        for (int i = 0; i < 3; i++)
        {
            foreach (string frame in personFrames)
            {
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine(frame);
                // Pause for 0.5 second            
            }            
        }

        Console.Clear();
        Console.WriteLine("Time's up! Answer the question now!");
        // Continue with the rest of your program logic
    }
        public virtual void DisplayQuestion()
    {
        //will be 1 question with the words of the scripture and 5 options of references
        List<Scripture> RandonScriptures = new List<Scripture>();
        Random random = new Random();
        if (GetScriptures().Count > 5)
        {
            // Gerar 5 índices aleatórios únicos
            HashSet<int> randonIndex = new HashSet<int>();
            while (randonIndex.Count < 5)
            {
                randonIndex.Add(random.Next(GetScriptures().Count));
            }
            // Adicionar os elementos correspondentes aos índices aleatórios à lista aleatória
            foreach (int index in randonIndex)
            {
                RandonScriptures.Add(GetScriptures()[index]);
            }
        }
        else
        {
            Console.WriteLine("Not enough scriptures to generate 5 random scriptures");            
        }
        // Select a random scripture
        Scripture randomScripture = RandonScriptures[random.Next(RandonScriptures.Count)];
        // Display the random scripture
        Console.WriteLine("");
        Console.WriteLine("Remember this scripture: ");
        Console.WriteLine(randomScripture.GetWords());

        // Display the options
        Console.WriteLine("Which of the following references are: ");
        Console.WriteLine("");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine((i + 1) + ". " + RandonScriptures[i].GetReference().GetReference());
        }
        //index for the right answer
        int rightAnswerIndex = RandonScriptures.IndexOf(randomScripture)+1;

        Console.WriteLine("Select an option: ");
        string answer = Console.ReadLine();

        if (answer == rightAnswerIndex.ToString())
        {
            Console.WriteLine("Correct!");
            AddRightAnswersCounter();
            Console.WriteLine("Your score: " + GetRightAnswersCounter()*GetPointsPerQuestion());
            SetAcumulatePoints(GetRightAnswersCounter()*GetPointsPerQuestion());
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }
    }

    public int GetPointsPerQuestion()
    {
        return _pointsPerQuestion;
    }

    public List<Scripture> GetScriptures()
    {
        return _scriptures;
    }

    public int GetAcumulatePoints()
    {
        return _acumulatePoints;
    }
    public void SetAcumulatePoints(int acumulatePoints)
    {
        _acumulatePoints = acumulatePoints;
    }

    public int GetRightAnswersCounter()
    {
        return _rightAnswersCounter;
    }

    public void AddRightAnswersCounter()
    {
        _rightAnswersCounter++;
    }
}
