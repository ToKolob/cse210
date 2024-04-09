
//medium mode
using System;
using System.Threading;

class SeminaryMode:GameMode
{
    public SeminaryMode( List<Scripture> scriptures ):base(scriptures)
    {
        SetNumberOfQuestions(5);
        SetPointsPerQuestion(50);
    }
    public override void StartGame()
    {
        StartMensage();
        Console.WriteLine("This time, you will have five questions. And 60 seconds to answer the questions.");

        LoadAnimation();

        //time to answer
        for (int i = 0; i < 5; i++)
        {
            DateTime time = DateTime.Now;
            int duration = 60;

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
