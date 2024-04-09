
//hard mode
class MissionaryMode:GameMode
{
    public MissionaryMode( List<Scripture> scriptures ):base(scriptures)
    {
        SetNumberOfQuestions(5);
        SetPointsPerQuestion(150);
    }
        public override void StartGame()
    {
        StartMensage();
        Console.WriteLine("This time, you will have five questions. And only 15 seconds to answer the questions.");

        LoadAnimation();

        //time to answer
        for (int i = 0; i < 5; i++)
        {
            DateTime time = DateTime.Now;
            int duration = 15;

            DisplayQuestion();
            if(DateTime.Now - time > TimeSpan.FromSeconds(duration))
            {                
                Console.WriteLine("Time is up! You will lose " + GetPointsPerQuestion() + " points");
                SetAcumulatePoints(GetAcumulatePoints() - GetPointsPerQuestion());
            }
        LoadAnimation();
        }        
    }
}