using System;

class Journal
{
    int _choice = 0;
    //instance of list entries

    public Journal()
    {
        _choice = Menu();
        Entry.ListEntries obj = new Entry.ListEntries;
    }
    public int Menu()
    {
        Console.WriteLine("Welcome to your personal journal! What do you want to do?");
        Console.WriteLine("Enter a number based on the following options");
        Console.WriteLine("1) Write a new entry");
        Console.WriteLine("2) Display the journal");
        Console.WriteLine("3) Save the journal to a file");
        Console.WriteLine("4) Load the journal from a file");
        Console.WriteLine("5) Exit the journal");
        int _choice = Int16.Parse(Console.ReadLine());
        return _choice;
    }

    public void RunJournal(_choice)
    {
        if (_choice == 1)
        {
            Entry entry = new Entry();
        }
        else if (_choice == 2)
        {
            // add code to display entries here
            Entry.ListEntries();
        }
        else if (_choice == 3)
        {
            JournalSaver save = new JournalSaver();
        }
        else if (_choice == 4)
        {
            JournalReader load = new JournalReader();
        }
        else if (_choice == 5)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Sorry, that is not an available option. Please enter again.");
        }
    }
}
