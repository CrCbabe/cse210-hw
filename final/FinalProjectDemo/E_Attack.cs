using System;

class E_Attack : Enemy
{
    bool isHit;
    // int playerDefense = GetPlayerDEF();
    // int playerHealth = GetPlayerHP();
    // int enemyAttack = GetEnemyATK();

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
        int hitChance = hitRoll - _playerDefense;
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
        int damage = _enemyAttack - _playerDefense;
        _playerHealth -= damage;
        SetPlayerHP(_playerHealth);
        Console.WriteLine($"Enemy attacks and deals {damage} damage!");
    }
}