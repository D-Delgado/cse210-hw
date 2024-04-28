using System;

class Program
{
    static void Main(string[] args)
    {
        string play_again = "yes";
        while (play_again == "yes")
        {        
            // User provided number logic
            // Console.Write("What is the magic number? ");
            // int answer = int.Parse(Console.ReadLine());
            
            // Logic for using random generator
            Random randomGenerator = new Random();
            int answer = randomGenerator.Next(1, 101);

            int user_guess = -1;

            int guess_count = 0;

            while (user_guess != answer)
            {
                guess_count += 1;
                Console.Write("What is your guess? ");
                user_guess = int.Parse(Console.ReadLine());

                if (answer > user_guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (answer < user_guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guess_count} guesses!");
                    Console.WriteLine("Want to play again? yes|no");
                    play_again = Console.ReadLine();
                }
            }
        }
    }
}