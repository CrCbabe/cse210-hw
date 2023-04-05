using System;

class Guard
{
    private int _defense;

    public Guard(int userDEF, string user)
    {
        userDEF = CheckDefense(userDEF);
        _defense = RaiseGuard(userDEF, user);
        UpdateDEF(_defense, user);
    }

    private int CheckDefense(int userDEF)
    {
        if (userDEF >= 4)
        {
            userDEF = 2;
        }
        return userDEF;
    }

    private int RaiseGuard(int userDEF, string user)
    {
        userDEF += 1;
        Console.WriteLine($"{user} has put their guard up.");
        Console.WriteLine($"{user} defense increased to {userDEF}.");
        return userDEF;
    }

    private void UpdateDEF(int defense, string user)
    {
        if (user == "Player")
        {
            Program._playerDefense = defense;
        }
        else
        {
            Program._enemyDefense = defense;
        }
    }
}