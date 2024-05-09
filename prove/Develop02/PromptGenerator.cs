using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

public class PromptGenerator
{
    public static string GetRandomPrompt()
    {
        List<string> _prompts = new List<string>
        {
            "What was one thing you are grateful for today",
            "What was one thing you learned today?",
            "Who did you interact with today? Elaborate on the interaction.",
            "Where did you go today and why?",
            "What was your most exciting thought today?"
        };

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPhrase = _prompts[index];

        public void Display()
        {
        Console.WriteLine(randomPhrase);
        }
    }
}