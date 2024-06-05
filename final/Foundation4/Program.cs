using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 6, 1), 30, 3),
            new Cycling(new DateTime(2024, 6, 2), 45, 10),
            new Swimming(new DateTime(2024, 6, 3), 60, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}