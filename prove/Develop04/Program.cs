using System;

class Program
{
    private static int choice;
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        while (choice != 4)
        {
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