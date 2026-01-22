using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Add 10 numbers: ");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{i + 1}. number: ");
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }

        int max = numbers.Max();
        int min = numbers.Min();
        double average = numbers.Average();

        Console.WriteLine($"Big: {max}");
        Console.WriteLine($"Small: {min}");
        Console.WriteLine($"Average: {average}");
    }
    
}

