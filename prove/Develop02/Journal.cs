public class Journal
{
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
        PromptGenerator prompt = GetRandomPrompt();
        newEntry = string Console.ReadLine();
    }

    public void DisplayAll()
    {
        Entry entry = new Entry();
        
    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }
}