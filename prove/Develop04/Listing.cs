using System;
using System.Collections.Generic;
using System.Threading;

class Listing : Activity
{
    private static string[] promptList = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?",
    };

    List<string> prompts = new List<string>(promptList);
    List<string> _responses = new List<string>();

    public Listing()
    {
        SetActivity();
        SetWelcome();
        SetDescription();
    }

    private void Instruction()
    {
        string _prompt = ChoosePrompt(prompts);
        GetReady();
        Console.WriteLine("List as many responses as you can to the following prompt the following prompt:");
        Console.WriteLine($" --- {_prompt} --- ");
        Console.WriteLine("When you have something in mind, press enter to continue,");
    }

    private void RunList()
    {

    }

    public override void SetWelcome()
    {
        _welcome = "Welcome to the Listing Activity";
    }

    public override void SetDescription()
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void SetActivity()
    {
        _activity = "Listing";
    }
}