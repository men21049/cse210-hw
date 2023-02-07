using System;


class MindFulness
{
    WaitingDisplay display = new WaitingDisplay();
    public MindFulness()
    {

        Activity newAct = new Activity("Initial Activity");
        SetActivity(newAct.DisplayMenu());
    }

    public void SetActivity(int choice)
    {
        if (choice == 1)
        {
            BreathingActivity breath = new BreathingActivity("Breathing");
            int numSecondsToRun = breath.DisplayWelcomeMessage();
            breath.DisplayGetReady();
            display.displaySpinner(5);
            display.displayCountDown(6, breath.getActivityList());
            breath.FinishActivity(numSecondsToRun, breath.getActivityName());
            display.displaySpinner(5);
            SetActivity(breath.DisplayMenu());
        }
        else if (choice == 2)
        {
            ReflectionActivity reflect = new ReflectionActivity("Reflection");
            int numSecondsToRun = reflect.DisplayWelcomeMessage();
            reflect.DisplayGetReady();
            display.displaySpinner(5);
        }
        else if (choice == 3)
        {
            ListingActivity listing = new ListingActivity("Listing");
            int numSecondsToRun = listing.DisplayWelcomeMessage();
            listing.DisplayGetReady();
            display.displaySpinner(5);
        }
        else
        {
            Environment.Exit(0);
        }
    }

    public void setActivityTime(int seconds)
    {

    }
}