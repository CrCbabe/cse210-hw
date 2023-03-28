using System;

class E_Attack : Enemy
{
    bool isHit;
    public E_Attack()
    {
        isHit = HitChance();
        if (isHit == true)
        {
            CalculateDamage();
        }
        else
        {
            Console.WriteLine("Enemy attacks and misses!");
        }
    }
    bool HitChance()
    {
        //add code here
        return isHit;
    }

    void CalculateDamage()
    {
        int damage = enemyAttack - playerDefense;
        playerHealth -= damage;
        Console.WriteLine($"Enemy attacks and deals {damage} damage!");
    }
}