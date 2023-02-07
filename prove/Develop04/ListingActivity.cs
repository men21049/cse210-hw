using System;

class ListingActivity : Activity
{
    List<string> activityList = new List<string> {"Who are people that you appreciate?"
                                                  ,"What are personal strengths of yours?"
                                                  ,"Who are people that you have helped this week?"
                                                  ,"When have you felt the Holy Ghost this month?"
                                                  ,"Who are some of your personal heroes?"};
    string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    public ListingActivity(string _activityName) : base(_activityName)
    {
        SetDescription(description);
        SetActivityList(activityList);
    }
}