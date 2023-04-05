using System;

class Distract
{
    private int _defense;

    public Distract(int victimDEF, string user, string victim)
    {
        victimDEF = CheckDefense(victimDEF);
        _defense = DistractFoe(victimDEF, user, victim);
        UpdateDEF(_defense, victim);
    }

    private int CheckDefense(int victimDEF)
    {
        if (victimDEF == 0)
        {
            victimDEF = 2;
        }
        return victimDEF;
    }

    private int DistractFoe(int victimDEF, string user, string victim)
    {
        victimDEF -= 1;
        Console.WriteLine($"{user} has distracted {victim}.");
        Console.WriteLine($"{victim} defense decreased to {victimDEF}.");
        return victimDEF;
    }

    private void UpdateDEF(int defense, string victim)
    {
        if (victim == "Player")
        {
            Program._playerDefense = defense;
        }
        else
        {
            Program._enemyDefense = defense;
        }
    }
}
