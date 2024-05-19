using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        int totalCounter = 0;
        int breathingActivityCounter = 0;
        int reflectionActivityCounter = 0;
        int listingActivityCounter = 0;
        
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine();

        while (choice != 4)
        {
            if (totalCounter > 0)
            {
                Console.WriteLine($"Number of times activities done:");
                Console.WriteLine($" Breathing Activity: {breathingActivityCounter}");
                Console.WriteLine($" Reflection Activity: {reflectionActivityCounter}");
                Console.WriteLine($" Listing Activity: {listingActivityCounter}");
                Console.WriteLine();
            }
        
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            if (choice == 1)
            {
                BreathingActivity breathA = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathA.Run();
                breathingActivityCounter += 1;
                totalCounter += 1;

                Console.Clear();
            }

            if (choice == 2)
            {
                ReflectingActivity refA = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                refA.Run();
                reflectionActivityCounter += 1;
                totalCounter += 1;
                
                Console.Clear();
            }

            if (choice == 3)
            {
                ListingActivity listA = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listA.Run();
                listingActivityCounter += 1;
                totalCounter += 1;
            }
        }
    }
}