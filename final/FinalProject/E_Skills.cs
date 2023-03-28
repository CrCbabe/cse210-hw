using System;

class E_Skill : Enemy
{
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
        enemyHealth += healAmount;
        Console.WriteLine($"Enemy restores {healAmount} health points.");
    }

    void Guard()
    {
        enemyDefense += 1;
        Console.WriteLine("Enemy has put their guard up.");
        Console.WriteLine("Enemy defense increased.");
    }

    void Focus()
    {
        enemyAttack += 1;
        Console.WriteLine("Enemy is focused.");
        Console.WriteLine("Enemy attack increased.");
    }

    void Distract()
    {
        playerDefense -= 1;
        Console.WriteLine("Enemy has distracted you.");
        Console.WriteLine("Player defense decreased");
    }
}