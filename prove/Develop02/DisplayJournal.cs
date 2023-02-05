using System;
using System.Collections.Generic;

class DisplayJournal
{
    public DisplayJournal()
    {
        Display();
    }
    public void Display()
    {
        foreach (var item in Program.saveHere)
        {
            Console.WriteLine($"\n{item}");
        }
    }
}