using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the magic number: ");
        string input = Console.ReadLine();
        int magic = int.Parse(input);

        Console.Write("Please enter your guess: ");
        string inputTwo = Console.ReadLine();
        int magicGuess = int.Parse(inputTwo);


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

        while (magicGuess != magic)
        {
            Console.Write("Please enter another guess: ");
            string inputThree = Console.ReadLine();
            magicGuess = int.Parse(inputThree);

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
        }
    }
}