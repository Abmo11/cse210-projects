using System;

class Program
{
    static void Main(string[] args)
    {
        // Restructured code to include a single do-while loop
        // to consolidate both if blocks. Also found cleaner way
        // to parse into ints from user input.


        // Creates a random number
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        // Variable for input
        int magicGuess;

        do
        {
            // Input parsed into an int
            Console.Write("Please enter your guess: ");
            magicGuess = int.Parse(Console.ReadLine());

            if (magicGuess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (magicGuess == magic)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.WriteLine("Higher");
            } 
        } while (magicGuess != magic); // Continues running until the number is guessed
    }
}