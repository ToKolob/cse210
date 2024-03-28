public class MathAssignment : Assignment
{
    string _textbookSection = "";
    string _problems = "";
    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        Console.WriteLine($"{_textbookSection} + {_problems} = {_textbookSection + _problems}");
        return $"{_textbookSection} + {_problems} = {_textbookSection + _problems}";
    }
}
