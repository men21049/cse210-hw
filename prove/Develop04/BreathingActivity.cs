using System;

class BreathingActivity : Activity
{
    List<string> activityList = new List<string> { "Breath in", "Breath out" };
    string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public BreathingActivity(string _activityName) : base(_activityName)
    {
        SetDescription(description);
        SetActivityList(activityList);
    }
}