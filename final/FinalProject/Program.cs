using System;
using System.Threading;

class Program
{
    static public int _playerHealth = 30;
    static public int _playerAttack = 5;
    static public int _playerDefense = 2;
    static public int _enemyHealth = 20;
    static public int _enemyAttack = 7;
    static public int _enemyDefense = 2;

    static void Main(string[] args)
    {
        while (_playerHealth > 0 || _enemyHealth > 0)
        {
            Player player = new Player(_playerHealth, _playerAttack, _playerDefense, _enemyHealth, _enemyDefense);
            Console.WriteLine($"Player HP - {_playerHealth}, Enemy HP - {_enemyHealth}");
            Thread.Sleep(2500);
            Enemy enemy = new Enemy(_enemyHealth, _enemyAttack, _enemyDefense, _playerHealth, _playerDefense);
            Console.WriteLine($"Player HP - {_playerHealth}, Enemy HP - {_enemyHealth}");
            Thread.Sleep(3500);
        }
        EndCombat();
    }

    private static void EndCombat()
    {
        if (_playerHealth > 0)
        {
            Console.WriteLine("Congratulations, you have won!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
    }
}