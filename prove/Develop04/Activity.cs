using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    private int _index;
    private string _prompt;
    protected string _activity;
    protected string _welcome;
    protected string _description;
    string[] _frames = {
        "\"",
        "|",
        "/",
        "-"
    };

    protected int Welcome()
    {
        Console.Clear();
        Console.WriteLine(_welcome);
        Console.WriteLine($"\n{_description}");
        Console.WriteLine("\nHow long, in seconds, would you like for your session?");
        int _duration = int.Parse(Console.ReadLine());
        return _duration;
    }

    protected void RunTimer(int time) //change to implement actual duration?
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime == futureTime)
        {
            Congrats(time, _activity); //maybe this works
        }
    }

    protected void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        PlayAnimation();
    }

    private void PlayAnimation()
    {
        foreach (string _frame in _frames)
        {
            Console.Write(_frame);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    protected void CountDown(int counter)
    {
        while (counter > 0)
        {
            Console.Write(counter);
            Thread.Sleep(1000);
            counter -= 1;
            Console.Write("\b \b");
        }
    }

    private void Congrats(int time, string activity)
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"\nYou have completed another {time} seconds of the {activity} Activity.");
    }

    protected string ChoosePrompt(List<string> prompts)
    {
        Random rand = new Random();
        _index = rand.Next(prompts.Count);
        _prompt = prompts[_index];
        prompts.Remove(_prompt);
        return _prompt;
    }

    public virtual void SetWelcome()
    {
        _welcome = "";
    }

    public virtual void SetDescription()
    {
        _description = "";
    }

    public virtual void SetActivity()
    {
        _activity = "";
    }


}