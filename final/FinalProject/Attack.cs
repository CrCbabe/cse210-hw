using System;

class Attack
{
    private bool isHit;
    private int remainingHP;

    public Attack(int userATK, int victimDEF, int victimHP, string user)
    {
        isHit = HitChance(victimDEF);
        if (isHit == true)
        {
            remainingHP = CalculateDamage(userATK, victimDEF, victimHP, user);
            UpdateHP(remainingHP, user);
        }
        else
        {
            Console.WriteLine($"{user} attacks and misses!");
        }
    }
    private bool HitChance(int victimDEF)
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

    private int CalculateDamage(int userATK, int victimDEF, int victimHP, string user)
    {
        int damage = userATK - victimDEF;
        victimHP -= damage;
        Console.WriteLine($"{user} attacks and deals {damage} damage!");
        return victimHP;
    }

    private void UpdateHP(int health, string user)
    {
        if (user == "Player")
        {
            Program._enemyHealth = health;
        }
        else
        {
            Program._playerHealth = health;
        }
    }
}
