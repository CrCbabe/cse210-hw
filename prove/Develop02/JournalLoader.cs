using System;

class JournalReader
{
    public void Read()
    {
        Console.WriteLine("Choose where you wish to load your journal from Please include the full file path:");
        string fileName = Console.ReadLine();
        string[] entries = System.IO.File.ReadAllLines(fileName);
        foreach (string entry in entries)
        {
            Console.WriteLine($"{entry}");
        }
    }

}