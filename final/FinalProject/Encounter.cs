using System;

class Encounter
{
    protected int _playerHealth = 30;
    protected int _playerAttack = 5;
    protected int _playerDefense = 2;
    protected int _enemyHealth = 20;
    protected int _enemyAttack = 7;
    protected int _enemyDefense = 2;
    protected int _healAmount = 3;

    public Encounter()
    {
        while (_playerHealth > 0 && _enemyHealth > 0)
        {
            RunCombatTurn();
        }
        EndCombat();
    }

    void RunCombatTurn()
    {
        Player player = new Player();
        Enemy enemy = new Enemy();
    }

    void EndCombat()
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

    public virtual void SetPlayerHP(int playerHP)
    {
        _playerHealth = playerHP;
    }

    public virtual void SetPlayerATK(int playerATK)
    {
        _playerAttack = playerATK;
    }

    public virtual void SetPlayerDEF(int playerDEF)
    {
        _playerDefense = playerDEF;
    }

    public virtual void SetEnemyHP(int enemyHP)
    {
        _enemyHealth = enemyHP;
    }

    public virtual void SetEnemyATK(int enemyATK)
    {
        _enemyAttack = enemyATK;
    }

    public virtual void SetEnemyDEF(int enemyDEF)
    {
        _enemyDefense = enemyDEF;
    }
}