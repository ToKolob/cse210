class GameSystem
{
    private bool _running = true;
    private int _points = 0;

    public GameSystem()
    {

    }
    public void Start()
    {

        Console.Clear();
        Console.WriteLine("Welcome to Scripture Quiz Show!");
        Console.WriteLine("Press enter to begin...");
        Console.ReadKey();
        Console.Clear();

        while (_running)
        {
            DataManager data = new DataManager();
            data.ReadFile("scriptures.txt");
            Console.WriteLine("");
            Console.WriteLine("Your score: " + _points);
            Console.WriteLine("");
            Console.WriteLine("Choose your mode game: ");
            Console.WriteLine("1. Quiz of references ----------------- Easy");
            Console.WriteLine("2. Seminary Questiions ---------------- Medium");
            Console.WriteLine("3. Missionary Challenge --------------- Hard");
            Console.WriteLine("4. Exit");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    Quiz quiz = new Quiz(data.GetFilteredScriptures("Seminary", "Pearl of Great Price"));
                    quiz.StartGame();
                    _points += quiz.GetAcumulatePoints();
                    break;
                case "2":
                    Console.Clear();
                    SeminaryMode seminary = new SeminaryMode( data.GetScriptures());
                    seminary.StartGame();
                    break;
                case "3":
                    Console.Clear();
                    MissionaryMode missionary = new MissionaryMode(data.GetScriptures());
                    missionary.StartGame();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    _running = false;
                    break;
                
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }            
    }


}
