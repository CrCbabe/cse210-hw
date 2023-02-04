using System;
using System.IO;

class JournalSaver
{
    //instance of list entries
    Entry.ListEntries _listEntries = new Entry.ListEntries();
    public void Save()
    {
        Console.WriteLine("Choose where you wish to save your journal to (Please include the full file path):");
        string _fileLocation = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileLocation))
        {
            outputFile.WriteLine(Entry.ListEntries());
        }
    }
}