using System;

class Journal
{
    int choice = int.Parse(Journal.Menu());
    public int Menu()
    {
        Console.WriteLine("Welcome to your personal journal! What do you want to do?");
        Console.WriteLine("Enter a number based on the following options");
        Console.WriteLine("1) Write a new entry");
        Console.WriteLine("2) Display the journal");
        Console.WriteLine("3) Save the journal to a file");
        Console.WriteLine("4) Load the journal from a file");
        Console.WriteLine("5) Exit the journal");
        int choice = Int16.Parse(Console.ReadLine());
        return choice;
    }

    public void RunJournal(choice)
    {
        if (choice = 1)
        {
            Entry;
        }
        else if (choice = 2)
        {
            // add code to display entries here
        }
        else if (choice = 3)
        {
            JournalSaver;
        }
        else if (choice = 4)
        {
            JournalReader;
        }
        else if (choice = 5)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Sorry, that is not an available option. Please enter again.");
        }
    }
}
