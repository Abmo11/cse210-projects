using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates a random number
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        // Variables for input and guess counter
        int magicGuess = 0;
        int counter = 0;

        do
        {
            // Input parsed into an int
            Console.Write("Please enter your guess: ");
            magicGuess = int.Parse(Console.ReadLine());
            counter++;

            if (magicGuess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (magicGuess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {   // Gives option of playing again when you win
                Console.WriteLine($"You guessed it! You made {counter} guesses.");
                Console.WriteLine("Would you like to play again? (Yes or No)");
                string answer = Console.ReadLine();

                if (answer == "Yes")
                {
                    magic = randomGenerator.Next(1, 101);
                    magicGuess = 0;
                    counter = 0;
                    Console.WriteLine("Let's play again!");
                }
                else
                {
                    Console.WriteLine("Thank you for playing.");
                }
            }
        } while (magicGuess != magic) ; // Continues running until the number is guessed
    }
}