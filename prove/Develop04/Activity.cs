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
        "-",
        "\\",
        "|",
        "/",
    };

    protected int Welcome()
    {
        Console.Clear();
        Console.WriteLine(_welcome);
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int _duration = int.Parse(Console.ReadLine());
        return _duration;
    }

    protected void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        PlayAnimation(3);
    }

    protected void PlayAnimation(int loops)
    {
        for (int i = 0; i < loops; i++)
        {
            foreach (string _frame in _frames)
            {
                Console.Write(_frame);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
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

    protected void Congrats(int time, string activity)
    {
        Console.WriteLine("\nWell done!!");
        PlayAnimation(2);
        Console.WriteLine($"\nYou have completed another {time} seconds of the {activity} Activity.");
        PlayAnimation(3);
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