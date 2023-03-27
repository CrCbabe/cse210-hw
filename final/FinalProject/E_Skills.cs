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

    }

    void Focus()
    {

    }

    void Distract()
    {

    }
}