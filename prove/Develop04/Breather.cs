using System;
using System.Threading;

class Breather : Activity
{
    public Breather()
    {
        SetActivity();
        SetWelcome();
        SetDescription();
        int time = Welcome();
        RunTimer(time);
        Breathe();
    }

    private void Breathe()
    {
        GetReady();
        Console.Write($"\nBreathe in...");
        CountDown(4);
        Console.Write($"\nBreathe out...");
        CountDown(6);
    }

    public override void SetWelcome()
    {
        _welcome = "Welcome to the Breathing Activity";
    }

    public override void SetDescription()
    {
        _description = "This activity will help you relax by walking through breathing in and our slowly. Clear you mind and focus on your breathing.";
    }

    public override void SetActivity()
    {
        _activity = "Breathing";
    }
}