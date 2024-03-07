partial class Program
{
    public class Resume
    {
        public string Name;
        public List<JobTitle> JobTitles = new List<JobTitle>();

        public void Display(){
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Jobs: ");
            foreach (JobTitle job in JobTitles){
                job.Display();
            }
        }
    }
}