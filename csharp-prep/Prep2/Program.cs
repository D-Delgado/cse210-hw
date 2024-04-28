using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);
        int digit = grade % 10;

        string symbol = "";
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        if (letter == "F" ^ grade >= 93)
        {
            Console.WriteLine($"Your grade is: {letter}");
        }
        else if (digit >= 7)
        {
            symbol ="+";
            Console.WriteLine($"Your grade is: {letter}{symbol}");    
        }
        else if (digit >= 3)
        {
            Console.WriteLine($"Your grade is: {letter}");
        }
        else if (digit < 3)
        {
            symbol = "-";
            Console.WriteLine($"Your grade is: {letter}{symbol}");
        }

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}