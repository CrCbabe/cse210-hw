using System;

class JournalLoader
{
    public JournalLoader()
    {
        Read();
    }

    public void Read()
    {
        Console.WriteLine("Choose where you wish to load your journal from (Please include the full file path):");
        string _fileName = Console.ReadLine();
        string[] _entries = System.IO.File.ReadAllLines(_fileName);
        foreach (string _entry in _entries)
        {
            string[] parts = _entry.Split("~");
        }
    }

}