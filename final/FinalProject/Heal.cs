using System;

class Heal
{
    public Heal(int userHP, string user)
    {
        Recover(userHP, user);
    }

    private void Recover(int userHP, string user)
    {
        userHP += 3;
        // SetEnemyHP(_enemyHealth);
        Console.WriteLine($"{user} restores 3 health points.");
    }
}