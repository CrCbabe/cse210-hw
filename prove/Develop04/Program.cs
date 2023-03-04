using System;

class Program
{
    private static int choice;
    static void Main(string[] args)
    {
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Breather breather = new Breather();
            }
            else if (choice == 2)
            {
                Reflect reflect = new Reflect();
            }
            else if (choice == 3)
            {
                Listing listing = new Listing();
            }
        }
    }
}

// Added method in activity to remove prompts when chosen (so there are no repeats)
// Used polymorphism to define the welcome, description, and activity attributes in each child class