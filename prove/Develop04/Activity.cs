using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    private int _index;
    private string _prompt;
    protected string _welcome;
    protected string _description;
    string[] _frames = {
        "\"",
        "|",
        "/",
        "-"
    };

    public void Timer(int time) //change to implement actual duration?
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("You have completed the activity");
        }
    }

    public void PlayAnimation()
    {
        foreach (string _frame in _frames)
        {
            Console.Write(_frame);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    protected int Welcome()
    {
        Console.Write(_welcome);
        Console.Write(_description);
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int _duration = int.Parse(Console.ReadLine());
        return _duration;
    }

    public virtual void SetWelcome()
    {
        _welcome = "";
    }

    public virtual void SetDescription()
    {
        _description = "";
    }

    private void Congrats(int time, string activity)
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"\nYou have completed another {time} seconds of the {activity} Activity.");
    }

    string ChoosePrompt(List<string> prompts)
    {
        while (prompts != ) //whilst the prompt list is not empty
        {
            Random rand = new Random();
            _index = rand.Next(prompts.Count);
            _prompt = prompts[_index];
            prompts.Remove(_prompt);
            return _prompt;
        }
    }
}