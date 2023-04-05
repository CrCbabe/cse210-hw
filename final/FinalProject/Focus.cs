using System;

class Focus
{
    public Focus(int userATK, string user)
    {
        IsFocused(userATK, user);
    }

    void IsFocused(int userATK, string user)
    {
        userATK += 1;
        // SetEnemyATK(_enemyAttack);
        Console.WriteLine($"{user} is focused.");
        Console.WriteLine($"{user} attack increased to {userATK}.");
    }
}