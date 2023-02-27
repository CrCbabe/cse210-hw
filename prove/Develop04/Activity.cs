using System;
using System.Threading;

class Activity
{
    public void Timer(int time)
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
        foreach (_frame in _frames)
        {
            Console.Write(_frame);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}