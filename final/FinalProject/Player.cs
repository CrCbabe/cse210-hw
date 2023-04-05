using System;

class Player
{
    private int _playerAction;
    public Player(int playerHP, int playerATK, int playerDEF, int enemyHP, int enemyDEF)
    {
        Console.WriteLine("-- Player Turn --");
        ChooseAction(playerHP, playerATK, playerDEF, enemyHP, enemyDEF);
    }
    void ChooseAction(int playerHP, int playerATK, int playerDEF, int enemyHP, int enemyDEF)
    {
        Console.WriteLine("Choose what you wish to do (type in the number):");
        Console.WriteLine("  1) Attack (deal damage to your enemy)");
        Console.WriteLine("  2) Heal (increases player Health)");
        Console.WriteLine("  3) Guard (temporarily increse player Defense)");
        Console.WriteLine("  4) Focus (temporarily increase player Attack)");
        Console.WriteLine("  5) Distract (temporarily decrease enemy Defense)");
        _playerAction = int.Parse(Console.ReadLine());
        Console.Clear();
        if (_playerAction == 1)
        {
            Attack attack = new Attack(playerATK, enemyDEF, enemyHP, "Player");
        }
        else if (_playerAction == 2)
        {
            Heal heal = new Heal(playerHP, "Player");
        }
        else if (_playerAction == 3)
        {
            Guard guard = new Guard(playerDEF, "Player");
        }
        else if (_playerAction == 4)
        {
            Focus focus = new Focus(playerATK, "Player");
        }
        else if (_playerAction == 5)
        {
            Distract distract = new Distract(enemyDEF, "Player", "Enemy");
        }
    }
}