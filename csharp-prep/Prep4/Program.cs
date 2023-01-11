using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a series of numbers, type 0 when finished: ");

        List<int> series = new List<int>();

        int numbers = 0;
        do
        {
            Console.Write("Enter number: ");
            numbers = int.Parse(Console.ReadLine());

            if (numbers != 0)
            {
                series.Add(numbers);
            }
        } while (numbers != 0);

        int sum = 0;
        double average = 0;
        foreach (int numeros in series)
        {
            sum += numeros;
            average = ((double)sum) / series.Count;
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");

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