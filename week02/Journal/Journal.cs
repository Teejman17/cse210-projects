using System.Threading.Tasks.Dataflow;

public class Journal
{
    public List<string> _entry = new List<string>();

    PromptGenerator GetPrompt = new PromptGenerator();

    public void Write()
    {
        string prompt = GetPrompt.GetPrompt();
        Console.WriteLine($"{prompt}");
        Console.Write("> ");
        string entry = Console.ReadLine();
        _entry.Add(entry);
    }

    public void Display()
    {
        foreach (string entry in _entry)
        {
            Console.WriteLine($"Entry:{entry}");
        }
    }

    public void Save()
    {
        Console.Write("Please enter file name you would like to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        foreach (string entry in _entry)
        {
            outputFile.WriteLine(entry);
        }
    }

    public void Load()
    {
        Console.Write("Please enter the file nae you would like to load from: ");
        string filename = Console.ReadLine();
        _entry.AddRange(System.IO.File.ReadAllLines(filename));
    }


    // Behavior:
    // Write(): void
    // Display(): void
    // Save(): void
    // Load() : void
}