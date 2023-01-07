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

        // Determines positive or negative sign
        string sign;
        if ((grade < 97 && grade > 60) && grade % 10 >= 7)
        {
            sign = "+";
        } // 100+ = remainders 0, 1, 2 gives a '-', grade>=100 corrects it
        else if (grade >= 100 || grade % 10 >= 3)
        {
            sign = "";
        }
        else 
        {
            sign = "-";
        }

        Console.WriteLine($"Your letter grade is {sign}{letter}");

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