using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks user for grade percentage, stores input
        Console.Write("Please enter your grade percentage: ");
        string gradePercent = Console.ReadLine();

        int grade = int.Parse(gradePercent);

        // Matches input to letter grade, displays letter grade
        string letter;

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

        Console.WriteLine(letter);

        // Determines if student passed the class
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass. Try again and you will do better.");
        }
    }
}