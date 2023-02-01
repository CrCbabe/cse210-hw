using System;

class JournalSaver
{
    public void Save()
    {
        Console.WriteLine("Choose where you wish to save your journal to (Please include the full file path):");
        public string fileLocation = Console.ReadLine();
    File.WriteAllLines(@fileLocation, Entry)
}
    
}