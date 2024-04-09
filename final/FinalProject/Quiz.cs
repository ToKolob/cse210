
//easy mode
class Quiz:GameMode
{
    string _sourceTheme;
    public Quiz( List<Scripture> scriptures, string source ):base(scriptures)    
    {
        _sourceTheme = source;
    }
    public override void StartGame()
    {
        StartMensage();
        Console.WriteLine("All scriptures will be from " + _sourceTheme);
        for (int i = 0; i < 5; i++)
        {
            DisplayQuestion();
            LoadAnimation();
        }        
    }
}
