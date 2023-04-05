using System;

class Distract
{
    private int defense;

    public Distract(int victimDEF, string user, string victim)
    {
        victimDEF = CheckDefense(victimDEF);
        defense = DistractFoe(victimDEF, user, victim);
        UpdateDEF(defense, victim);
    }

    int CheckDefense(int victimDEF)
    {
        if (victimDEF == 0)
        {
            victimDEF = 2;
        }
        return victimDEF;
    }

    int DistractFoe(int victimDEF, string user, string victim)
    {
        victimDEF -= 1;
        // SetPlayerDEF(_playerDefense);
        Console.WriteLine($"{user} has distracted {victim}.");
        Console.WriteLine($"{victim} defense decreased to {victimDEF}.");
        return victimDEF;
    }

    void UpdateDEF(int defense, string victim)
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
