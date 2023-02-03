using System;

class Program
{
    static void Main(string[] args)
    {
        string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        List<string> activityList = new List<string> { "Breath in", "Breath out" };

        BreathingActivity newAct = new BreathingActivity("breathing", description, activityList);


        Activity.DisplayMenu();


    }
}