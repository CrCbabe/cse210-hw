using System;

class P_Skill : Player
{
    public P_Skill()
    {
        Console.WriteLine("Choose what skill you wish to use (type in the number):");
        Console.WriteLine("  1) Heal (increases player Health)");
        Console.WriteLine("  2) Guard (temporarily increse player Defense)");
        Console.WriteLine("  3) Focus (temporarily increase player Attack)");
        Console.WriteLine("  4) Distract (temporarily decrease enemy Defense)");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Heal();
        }
        else if (choice == 2)
        {
            Guard();
        }
        else if (choice == 3)
        {
            Focus();
        }
        else if (choice == 4)
        {
            Distract();
        }
    }
    void Heal()
    {
        playerHealth += healAmount;
        Console.WriteLine($"Player restores {healAmount} health points.");
    }

    void Guard()
    {
        playerDefense += 1;
        Console.WriteLine("You have put your guard up.");
        Console.WriteLine("Player defense increased.");
    }

    void Focus()
    {
        playerAttack += 1;
        Console.WriteLine("You are focused.");
        Console.WriteLine("Player attack increased.");
    }

    void Distract()
    {
        enemyDefense -= 1;
        Console.WriteLine("You have distracted your opponent.");
        Console.WriteLine("Enemy defense decreased");
    }
}