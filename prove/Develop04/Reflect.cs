using System;
using System.Collections.Generic;
using System.Threading;

class Reflect : Activity
{
    List<string> prompts = new List<string>();

    public override void SetWelcome()
    {
        _welcome = "Welcome to the Reflection Activity";
    }

    public override void SetDescription()
    {
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void SetActivity()
    {
        _activity = "Reflecting";
    }
}