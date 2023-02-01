using System;

class JournalReader
{
    public void Read()
    {
        Console.WriteLine("Choose where you wish to load your journal from Please include the full file path:");
        public string fullPath = Console.ReadLine();
    string readText = File.ReadAllText(@fullPath);
    Console.WriteLine(readText);
    }

}