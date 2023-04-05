using System;

class Program
{
    static int _playerHealth = 30;
    static int _playerAttack = 5;
    static int _playerDefense = 2;
    static int _enemyHealth = 20;
    static int _enemyAttack = 7;
    static int _enemyDefense = 2;

    static void Main(string[] args)
    {
        Player player = new Player(_playerHealth, _playerAttack, _playerDefense, _enemyHealth, _enemyDefense);
        Enemy enemy = new Enemy(_enemyHealth, _enemyAttack, _enemyDefense, _playerHealth, _playerDefense);
    }
}