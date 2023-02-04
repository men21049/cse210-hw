using System;


class MindFulness{

    public MindFulness(){
        
        BreathingActivity newAct = new BreathingActivity("breathing");
        Activity.DisplayMenu();
        newAct.DisplayWelcomeMessage();
    }
}