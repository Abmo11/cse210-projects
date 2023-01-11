using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a series of numbers, type 0 when finished: ");

        // Creates empty list
        List<int> series = new List<int>();

        int numbers = 0;
        do
        {
            Console.Write("Enter number: ");
            numbers = int.Parse(Console.ReadLine());

            // Adds number to the list as long as it's not 0
            if (numbers != 0) 
            {
                series.Add(numbers);
            }
        } while (numbers != 0); // Runs as long as 0 is not entered

        // Adds all numbers in list
        int sum = 0;
        foreach (int numeros in series)
        {
            sum += numeros;
        }

        // Calculates average into double.
        // If you don't cast sum into double it will do
        // int division and cut off decimal places
        double average = ((double)sum) / series.Count;
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");

        // Compares numbers in list to 0.
        // Changes max to greatest # as it goes through list
        int max = 0;
        foreach (int num in series)
        {
            if (num > max)
            {
                max = num;
            }
        }
        
        Console.WriteLine($"The largest number is: {max}");
    }
}