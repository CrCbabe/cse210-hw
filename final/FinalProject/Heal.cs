using System;

class Heal
{
    private int _health;

    public Heal(int userHP, string user)
    {
        _health = Recover(userHP, user);
        UpdateHP(_health, user);
    }

    private int Recover(int userHP, string user)
    {
        userHP += 3;
        Console.WriteLine($"{user} restores 3 health points.");
        return userHP;
    }

    private void UpdateHP(int health, string user)
    {
        if (user == "Player")
        {
            Program._playerHealth = health;
        }
        else
        {
            Program._enemyHealth = health;
        }
    }
}