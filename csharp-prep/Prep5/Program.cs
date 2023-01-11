using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int square = SquareNumber(favNumber);
        DisplayResult(name, square);
    }

    // Displays a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Asks for user name and returns it 
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // Asks for user's favorite number and returns it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    // Takes in fav #, squares it, returns it
    static int SquareNumber(int num)
    {
        int square = num * num;
        return square;
    }

    // Takes in name and the square of fav # and displays message
    static void DisplayResult(string name, int sqr)
    {
        Console.WriteLine($"{name}, the square of your number is {sqr}");
    }

}    