using System;
using System.Threading;

class Breather : Activity
{
    public Breather()
    {
        int time = Welcome();

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