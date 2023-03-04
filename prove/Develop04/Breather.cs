using System;
using System.Threading;
using System.Diagnostics;

class Breather : Activity
{
    Stopwatch timer = new Stopwatch();
    public Breather()
    {
        SetActivity();
        SetWelcome();
        SetDescription();
        int time = Welcome();
        Breathe(time);
        Congrats(time, _activity);
    }

    private void Breathe(int time)
    {
        GetReady();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < time)
        {
            Console.Write($"\nBreathe in...");
            CountDown(4);
            Console.Write($"\nBreathe out...");
            CountDown(6);
        }
        timer.Stop();
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