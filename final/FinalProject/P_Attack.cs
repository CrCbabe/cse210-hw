using System;

class P_Attack : Player
{
    bool isHit;

    public P_Attack()
    {
        isHit = HitChance();
        if (isHit == true)
        {
            CalculateDamage();
        }
        else
        {
            Console.WriteLine("Player attacks and misses!");
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
        int damage = playerAttack - enemyDefense;
        enemyHealth -= damage;
        Console.WriteLine($"Player attacks and deals {damage} damage!");
    }
}