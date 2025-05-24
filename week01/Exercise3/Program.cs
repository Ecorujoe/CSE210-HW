using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = -1;

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        string playAgain;
        do
        {
            int guessCount = 0;
            do
            {
                Console.Write("What is Your Guess? ");
                    string userGuess = Console.ReadLine();
                    guess = int.Parse(userGuess);
                    guessCount++;

                {



                    if (guess == magicNumber)
                    {
                        Console.WriteLine("You Guessed it!");
                        Console.WriteLine($"It took you {guessCount} Guesses");
                    }

                    else if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }

                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }


                }
            } while (magicNumber != guess);

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().Trim().ToLower();

        } while (playAgain == "yes");
        Console.WriteLine("Thanks or playing! Goodbye.");
    }
}