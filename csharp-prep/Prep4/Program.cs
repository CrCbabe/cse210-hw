using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        while (number != 0) {
            numbers.Add(number);
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"The sum is: " + numbers.AsEnumerable().Sum());
        Console.WriteLine("The average is: " + Queryable.Average(numbers.AsQueryable()));
        Console.WriteLine("The largest number is: " + numbers.Max());
    }
}