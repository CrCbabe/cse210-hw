using System;
using System.IO;

class JournalSaver
{
    //instance of list entries
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