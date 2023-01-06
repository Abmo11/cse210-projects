using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks for first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Asks for last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Adds a space in between the inputs and final output
        Console.WriteLine();

        // Displays name 007 style
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}