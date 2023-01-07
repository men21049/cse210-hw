using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> inputNumberList = new List<int>();
        int inputNumber;
        bool keepEntering = true;

        while (keepEntering)
        {
            Console.WriteLine("Enter number: ");
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber == 0)
            {
                keepEntering = false;
            }
            else
            {
                inputNumberList.Add(inputNumber);
            }
        }
        int sumList = inputNumberList.AsQueryable().Sum();
        Console.WriteLine($"The sum is {sumList}");
        double average = inputNumberList.Count > 0 ? inputNumberList.Average() : 0.0;
        Console.WriteLine($"The average is {average}");
        int max = inputNumberList.Max();
        Console.WriteLine($"The largest number is {max}");

    }
}