using System;

class Program
{
    static void Main(string[] args)
    {
        Random rd = new Random();
        int randNum = rd.Next(1, 20);
        int counter = 0;
        int numGuess = 0;
        bool wantToPlay = true;
        string question = "What is your guess? ";
        string keepPlaying = "yes";

        while (wantToPlay)
        {
            Console.WriteLine($"{question}");
            numGuess = int.Parse(Console.ReadLine());
            counter += 1;
            if (numGuess == randNum)
            {
                Console.WriteLine("You guessed it!, Do you want to keep playing?(yes/no) ");
                keepPlaying = Console.ReadLine();
                if (keepPlaying == "no")
                {
                    wantToPlay = false;
                }
            }
            else if (numGuess < randNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
    }
}