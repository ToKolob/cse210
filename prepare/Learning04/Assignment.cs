public class Assignment
{
    public Assignment(string name, string topic){
        _name = name;
        _topic = topic;
    }
    private string _name;
    private string _topic;  

    public string GetSummary()
    {
        Console.WriteLine($"{_name} - {_topic}");
        return $"{_name} - {_topic}";

    }    
}
