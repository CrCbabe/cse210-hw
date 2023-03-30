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
        Random random = new Random();
        int hitRoll = random.Next(1, 6);
        int hitChance = hitRoll - enemyDefense;
        if (hitChance > 0)
        {
            isHit = true;
        }
        else
        {
            isHit = false;
        }
        return isHit;
    }

    void CalculateDamage()
    {
        int damage = enemyAttack - playerDefense;
        playerHealth -= damage;
        Console.WriteLine($"Enemy attacks and deals {damage} damage!");
    }
}