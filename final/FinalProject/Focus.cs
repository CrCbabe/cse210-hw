using System;

class Focus
{
    private int _attack;

    public Focus(int userATK, string user)
    {
        _attack = IsFocused(userATK, user);
        UpdateATK(_attack, user);
    }

    private int IsFocused(int userATK, string user)
    {
        userATK += 1;
        Console.WriteLine($"{user} is focused.");
        Console.WriteLine($"{user} attack increased to {userATK}.");
        return userATK;
    }

    private void UpdateATK(int attack, string user)
    {
        if (user == "Player")
        {
            Program._playerAttack = attack;
        }
        else
        {
            Program._enemyAttack = attack;
        }
    }
}