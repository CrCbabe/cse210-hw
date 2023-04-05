using System;

class Distract
{
    public Distract(int victimDEF, string user, string victim)
    {
        victimDEF = CheckDefense(victimDEF);
        DistractFoe(victimDEF, user, victim);
    }

    int CheckDefense(int victimDEF)
    {
        if (victimDEF == 0)
        {
            victimDEF = 2;
        }
        return victimDEF;
    }

    void DistractFoe(int victimDEF, string user, string victim)
    {
        victimDEF -= 1;
        // SetPlayerDEF(_playerDefense);
        Console.WriteLine($"{user} has distracted {victim}.");
        Console.WriteLine($"{victim} defense decreased to {victimDEF}.");
    }
}
