using System;

class Attack
{
    private bool isHit;

    public Attack(int userATK, int victimDEF, int victimHP, string user)
    {
        isHit = HitChance(victimDEF);
        if (isHit == true)
        {
            CalculateDamage(userATK, victimDEF, victimHP, user);
        }
        else
        {
            Console.WriteLine($"{user} attacks and misses!");
        }
    }
    bool HitChance(int victimDEF)
    {
        Random random = new Random();
        int hitRoll = random.Next(1, 6);
        int hitChance = hitRoll - victimDEF;
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

    void CalculateDamage(int userATK, int victimDEF, int victimHP, string user)
    {
        int damage = userATK - victimDEF;
        victimHP -= damage;
        // SetPlayerHP(_playerHealth);
        Console.WriteLine($"{user} attacks and deals {damage} damage!");
    }
}
