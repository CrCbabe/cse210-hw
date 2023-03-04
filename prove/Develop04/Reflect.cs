using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

class Reflect : Activity
{
    Stopwatch timer = new Stopwatch();

    private static string[] promptList = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static string[] questionList = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
    };

    List<string> prompts = new List<string>(promptList);
    List<string> questions = new List<string>(questionList);

    public Reflect()
    {
        SetActivity();
        SetWelcome();
        SetDescription();
        int time = Welcome();
        Instruction();
        Reflection(time);
        Congrats(time, _activity);
    }

    private void Instruction()
    {
        string _prompt = ChoosePrompt(prompts);
        GetReady();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n --- {_prompt} --- ");
        Console.Write("\nWhen you have something in mind, press enter to continue,");
        CountDown(5);
    }

    private void Reflection(int time)
    {
        timer.Start();
        while (timer.Elapsed.TotalSeconds < time)
        {

        }
        timer.Stop();
    }

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