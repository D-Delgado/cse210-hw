using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Reference r1 = new Reference("Matthew", 5, 44);
        Console.Write($"{r1.GetDisplayText()} ");

        Scripture s1 = new Scripture(r1, "But I say unto you, Love your enemies, bless them that curse you, do good to them that hate you, and pray for them which despitefully use you, and persecute you;");
        Console.WriteLine(s1.GetDisplayText());
        string choice = "";
        

        while (choice != "quit")
        {
            
            s1.HideRandomWords(3);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            choice = Console.ReadLine();
            Console.Clear();
            
            Console.Write($"{r1.GetDisplayText()} ");
            Console.WriteLine(s1.GetDisplayText());
            
            
            if (s1.IsCompletelyHidden() == true)
            {
                
                choice = "quit";
                Console.WriteLine("All words hidden.");
                
                
            }
        }
    }
}