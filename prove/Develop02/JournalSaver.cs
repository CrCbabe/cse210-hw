using System;

class JournalSaver
{
    public JournalSaver()
    {
        Save();
    }
    public void Save()
    {
        Console.WriteLine("Choose where you wish to save your journal to:");
        string _fileLocation = Console.ReadLine();
        string file = ($"{_fileLocation}.txt");
        Program.saveHere.Add(file);
    }
}