using System;

class Guard
{
    public Guard(int userDEF, string user)
    {
        userDEF = CheckDefense(userDEF);
        RaiseGuard(userDEF, user);
    }

    private int CheckDefense(int userDEF)
    {
        if (userDEF >= 4)
        {
            userDEF = 2;
        }
        return userDEF;
    }

    private void RaiseGuard(int userDEF, string user)
    {
        userDEF += 1;
        // SetEnemyDEF(_enemyDefense);
        Console.WriteLine($"{user} has put their guard up.");
        Console.WriteLine($"{user} defense increased to {userDEF}.");
    }
}