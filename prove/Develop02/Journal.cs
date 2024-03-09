partial class Program
{
    public class Journal {
        public List<Entry> entries = new List<Entry>();

        public void DisplayAll(){
            Console.WriteLine("Entries: ");
            foreach (Entry entry in entries){
                Console.WriteLine($"Date: {entry._date}");
                Console.WriteLine($"Prompt: {entry._promptText}");
                Console.WriteLine($"Entry: {entry._entryText}");
                Console.WriteLine();
            }            
        }
        public void Add(Entry entry){
            entries.Add(entry);
        }
        public void WriteText(){
            Console.WriteLine("Save as:");
            string fileName = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                
                foreach (Entry entry in entries){
                    outputFile.WriteLine($"{entry._date}");
                    outputFile.WriteLine($"{entry._promptText}");
                    outputFile.WriteLine($"{entry._entryText}");
                }
            }            
        }
        public void ReadText(){
            Console.WriteLine("Open file:");
            string fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(fileName);

            for (int i = 0; i < lines.Length; i += 3)
            {
                Entry entry = new Entry();
                entry._date = lines[i];
                entry._promptText = lines[i + 1];
                entry._entryText = lines[i + 2];

                // Adiciona a entrada à lista de entradas do Journal
                entries.Add(entry);
            }
        }


    } 
}