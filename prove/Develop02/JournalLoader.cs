using System;
using System.IO;

class JournalLoader
{
    public JournalLoader()
    {
        Read();
    }
    public string _filename = "";
    public void Read()
    {
        Console.WriteLine("Choose where you wish to load your journal from:");
        string _fileName = Console.ReadLine();
        string[] _entries = File.ReadAllLines($"{_fileName}.txt");
        foreach (string entry in _entries)
        {
            Program.saveHere.Add(entry);
        }
    }
}