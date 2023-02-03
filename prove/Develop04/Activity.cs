using System;


class Activity
{

    private string activityName = string.Empty;
    private List<string> activityList;
    private string description = string.Empty;

    public Activity(string _activityName, string _description, List<string> _activityList)
    {
        activityName = _activityName;
        description = _description;
        activityList = _activityList;

    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1.- Start breathing activity");
        Console.WriteLine("   2.- Start reflection activity");
        Console.WriteLine("   3.- Start listing activity");
        Console.WriteLine("   4.- Quit");
        Console.
    }

}