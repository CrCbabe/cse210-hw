using System;
using System.IO;

class JournalSaver
{
    public void Save()
    {
        Console.WriteLine("Choose where you wish to save your journal to (Please include the full file path):");
        string fileLocation = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileLocation))
        {
            outputFile.WriteLine(Entry.ListEntries());
        }
    }
}