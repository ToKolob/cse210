public class WritingAssignment : Assignment
{
    public WritingAssignment(string name, string topic, string body) : base(name, topic)
    {
        _body = body;
    }
    private string _body;
    public string GetWritingInformation()
    {
        Console.WriteLine($"{_body} ");
        return $"{_body}";
    }
}
