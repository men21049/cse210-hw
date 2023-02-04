using System;


class Activity
{

    private string activityName = string.Empty;
    private List<string> activityList;
    private string description = string.Empty;

    public Activity(string _activityName)
    {
        activityName = _activityName;
    }

    public void SetDescription(string _description){
        description = _description;
    }

    public void SetActivityList(List<string> _activityList){

        activityList = _activityList.ToList();
    }
    public static int DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1.- Start breathing activity");
        Console.WriteLine("   2.- Start reflection activity");
        Console.WriteLine("   3.- Start listing activity");
        Console.WriteLine("   4.- Quit");
        Console.WriteLine("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        return choice;
    }

    public void DisplayWelcomeMessage(){
        Console.WriteLine($"Welcome to the {char.ToUpper(activityName[0])} Activity");
        Console.WriteLine($"{description}");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        SetNumberOFSeconds(seconds);
    }

    public void SetNumberOFSeconds(int number){

    }
}