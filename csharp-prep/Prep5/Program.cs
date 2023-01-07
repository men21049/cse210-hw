using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
        string name = PromptUserName();
        int squareNumber = SquareNumber(PromptUserNumber());
        Console.WriteLine($"Brother {name}, the square of your number is {squareNumber}");


    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }
}