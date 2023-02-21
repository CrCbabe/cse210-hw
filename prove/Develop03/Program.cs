using System;

class RunProgram
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.DisplayScripture();
        Console.WriteLine("\nPress Enter to continue, or type 'quit' to finish");
        string _input = Console.ReadLine();
        while (_input != "quit")
        {
            Console.Clear();
            scripture.HideWords();
            scripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to continue, or type 'quit' to finish");
            _input = Console.ReadLine();
        }
    }
}

// included code in Reference class to randomly chose a scripture from an array