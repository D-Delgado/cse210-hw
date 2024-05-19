public class BreathingActivity : Activity
{
    
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    public void Run()
    {
        DisplayStartingMessasge();
        Console.WriteLine();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowTimer(6);
            Console.Write("Now breathe out...");
            ShowTimer(6);
            Console.WriteLine();
            
        }

        DisplayEndMessage();
        ShowSpinner(5);

    }
}