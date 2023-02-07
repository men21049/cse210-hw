using System;
using System.Diagnostics;
using System.Threading;

class WaitingDisplay
{
    int spinnerCounter = 0;

    public WaitingDisplay()
    {

    }

    public void displaySpinner(int numSecondsToRun)
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        while (stopWatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.Write("");
        Console.WriteLine("");
    }

    public void displayCountDown(int numSecondsToRun, List<string> list)
    {
        foreach (string item in list)
        {
            for (int i = numSecondsToRun; i >= 1; i--)
            {
                Console.Write($"{item}...{i}");
                Console.SetCursorPosition(0, Console.CursorTop);
                Thread.Sleep(1000);
            }
            Console.WriteLine("");
        }

    }
}