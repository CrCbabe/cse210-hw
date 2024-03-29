using System;

class P_Skill : Player
{
    // int playerHealth = GetPlayerHP();
    // int playerDefense = GetPlayerDEF();
    // int playerAttack = GetPlayerATK();
    // int enemyDefense = GetEnemyDEF();

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
        _playerHealth += 3;
        SetPlayerHP(_playerHealth);
        Console.WriteLine("Player restores 3 health points.");
    }

    void Guard()
    {
        if (_playerDefense >= 4)
        {
            _playerDefense = 2;
        }
        _playerDefense += 1;
        SetPlayerDEF(_playerDefense);
        Console.WriteLine("You have put your guard up.");
        Console.WriteLine("Player defense increased.");
    }

    void Focus()
    {
        _playerAttack += 1;
        SetPlayerATK(_playerAttack);
        Console.WriteLine("You are focused.");
        Console.WriteLine("Player attack increased.");
    }

    void Distract()
    {
        if (_enemyDefense == 0)
        {
            _enemyDefense = 2;
        }
        _enemyDefense -= 1;
        SetEnemyDEF(_enemyDefense);
        Console.WriteLine("You have distracted your opponent.");
        Console.WriteLine("Enemy defense decreased");
    }
}