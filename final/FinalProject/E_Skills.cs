using System;

class E_Skill : Enemy
{
    // int enemyHealth = GetEnemyHP();
    // int enemyAttack = GetEnemyATK();
    // int enemyDefense = GetEnemyDEF();
    // int playerDefense = GetPlayerDEF();

    public E_Skill()
    {
        enemyAction = ChooseRandomAction();
        if (enemyAction == 0)
        {
            Heal();
        }
        else if (enemyAction == 1)
        {
            Guard();
        }
        else if (enemyAction == 2)
        {
            Focus();
        }
        else
        {
            Distract();
        }
    }
    void Heal()
    {
        _enemyHealth += 3;
        SetEnemyHP(_enemyHealth);
        Console.WriteLine("Enemy restores 3 health points.");
    }

    void Guard()
    {
        if (_enemyDefense >= 4)
        {
            _enemyDefense = 2;
        }
        _enemyDefense += 1;
        SetEnemyDEF(_enemyDefense);
        Console.WriteLine("Enemy has put their guard up.");
        Console.WriteLine("Enemy defense increased.");
    }

    void Focus()
    {
        _enemyAttack += 1;
        SetEnemyATK(_enemyAttack);
        Console.WriteLine("Enemy is focused.");
        Console.WriteLine("Enemy attack increased.");
    }

    void Distract()
    {
        if (_playerDefense == 0)
        {
            _playerDefense = 2;
        }
        _playerDefense -= 1;
        SetPlayerDEF(_playerDefense);
        Console.WriteLine("Enemy has distracted you.");
        Console.WriteLine("Player defense decreased");
    }
}