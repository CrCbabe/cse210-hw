using System;
using System.Collections.Generic;
using System.Threading;

class Listing : Activity
{
    private string _activity = "Listing";
    List<string> prompts = new List<string>();

    public override void SetWelcome()
    {
        _welcome = "Welcome to the Listing Activity";
    }

    public override void SetDescription()
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
}