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
            // SetEnemyHP(health);
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
        int hitChance = hitRoll - _enemyDefense;
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

    int CalculateDamage()
    {
        int damage = _playerAttack - _enemyDefense;
        _enemyHealth -= damage;
        SetEnemyHP(_enemyHealth);
        Console.WriteLine($"Player attacks and deals {damage} damage!");
        return _enemyHealth;
    }
}