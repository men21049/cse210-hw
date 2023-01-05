using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        int courseGrade = int.Parse(Console.ReadLine());
        string letter;
        string message = "Congratulations, you passed with a ";
        string sign = "+";
        int modGrade = courseGrade % 10;

        if (modGrade < 7)
        {
            sign = "-";
        }

        if (courseGrade >= 90)
        {
            letter = "A";
        }
        else if (courseGrade < 90 && courseGrade >= 80)
        {
            letter = "B";
        }
        else if (courseGrade < 80 && courseGrade >= 70)
        {
            letter = "C";
        }
        else if (courseGrade < 70 && courseGrade >= 60)
        {
            letter = "D";
            message = "You did not passed, your grade is ";
        }
        else
        {
            letter = "F";
            message = "You did not passed, your grade is ";
        }

        if (courseGrade >= 97 || letter == "F")
        {
            Console.WriteLine($"{message} {letter}");
        }
        else
        {
            Console.WriteLine($"{message} {letter}{sign}");
        }
    }
}