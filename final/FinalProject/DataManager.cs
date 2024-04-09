
class DataManager
{
    private List<Scripture> _scriptures;
    public DataManager()
    {
        _scriptures = new List<Scripture>(); // Inicialize a lista no construtor
    }
    public void ReadFile(string filePath)
    {
        /*File structure
        ¬¬¬
        Type of scripture
        Source
        Book
        Chapter
        StartVerse
        EndVerse
        Texts...
        ¬¬¬
        */

        if (File.Exists(filePath))
        {
            // Each are separate for ¬¬¬
            string content = File.ReadAllText(filePath);

            string[] parts = content.Split("¬¬¬\r\n");

            foreach (string part in parts)
            {
                //create a reference for lines 0 to 5
                string[] parts2 = part.Split("\r\n");
                string type = parts2[0];
                string source = parts2[1];
                string book = parts2[2];
                int chapter = int.Parse(parts2[3]);
                int startVerse = int.Parse(parts2[4]);
                int endVerse = int.Parse(parts2[5]);

                //Console.WriteLine(type + " " + source + " " + book + " " + chapter + " " + startVerse + " " + endVerse);

                //create list of words for lines 6 and forward
                string words = "";           
                for (int i = 6; i < parts2.Length; i++)
                {
                    words += parts2[i] + " ";
                }

                _scriptures.Add(new Scripture(new Reference(type, source, book, chapter, startVerse, endVerse), words));
            }
        }
    }

    public List<Scripture> GetScriptures()
    {
        return _scriptures;
    }
    public List<Scripture> GetFilteredScriptures(string type, string source)
    {
        List<Scripture> filteredScriptures = new List<Scripture>();
        foreach (Scripture scripture in _scriptures)
        {
            if (scripture.GetReference().GetTypeS() == type && scripture.GetReference().GetSource() == source)
            {
                filteredScriptures.Add(scripture);
            }
        }
        return filteredScriptures;
    }
    public List<Scripture> GetFilteredScriptures(string type)
    {
        List<Scripture> filteredScriptures = new List<Scripture>();
        foreach (Scripture scripture in _scriptures)
        {
            if (scripture.GetReference().GetTypeS() == type)
            {
                filteredScriptures.Add(scripture);
            }
        }
        return filteredScriptures;
    }
    public List<Scripture> GetFilteredScriptures(int none, string source)
    {
        int noUse = none;
        noUse ++;
        List<Scripture> filteredScriptures = new List<Scripture>();
        foreach (Scripture scripture in _scriptures)
        {
            if (scripture.GetReference().GetSource() == source)
            {
                filteredScriptures.Add(scripture);
            }
        }
        return filteredScriptures;
    }

}
