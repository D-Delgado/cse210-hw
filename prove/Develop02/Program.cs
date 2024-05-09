using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayMenu();
        Console.Write("What would you like to do? ");
        int choice = Console.ReadLine();

        if (choice == 1)
        {
            PromptGenerator prompt = GetRandomPrompt();
            Console.WriteLine(
        }
        else if (choice == 2)
        {
            letter = "B";
        }
        else if (choice == 3)
        {

        }
        else if (choice == 4)
        {
            
        }
        else if (choice == 5)
        {
            
        }



    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the journal Program!");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }
}