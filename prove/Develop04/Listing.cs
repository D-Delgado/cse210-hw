public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _count = 0;
        
    }

    public void Run()
    {
        DisplayStartingMessasge();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Write as many responses as you can to the following prompt:");
        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowTimer(7);
        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            GetListFromUser();
            _count += 1;
        }
        
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayEndMessage();
        ShowSpinner(7);
        Console.Clear();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        string prompt = _prompts[i];
        Console.WriteLine($" --- {prompt} ---");
        
        return prompt;
        
    }
    public List<string> GetListFromUser()
    {
        List<string> userInputs = new List<string>();
        string userInput = Console.ReadLine();
        
        userInputs.Add(userInput);
        return userInputs;
    }
}