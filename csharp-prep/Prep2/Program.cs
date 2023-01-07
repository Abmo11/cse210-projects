using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks user for grade percentage, stores input
        Console.Write("Please enter your grade percentage: ");
        string gradePercent = Console.ReadLine();

        int grade = int.Parse(gradePercent);

        // Matches input to letter grade
        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

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