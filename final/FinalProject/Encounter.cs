using System;

class Encounter
{
    protected int _playerHealth;
    protected int _playerAttack;
    protected int _playerDefense;
    protected int _enemyHealth;
    protected int _enemyAttack;
    protected int _enemyDefense;

    public Encounter()
    {
        SetStats();
        while (_playerHealth > 0 || _enemyHealth > 0)
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

    // public int GetPlayerHP()
    // {
    //     return _playerHealth;
    // }

    // public int GetPlayerATK()
    // {
    //     return _playerAttack;
    // }

    // public int GetPlayerDEF()
    // {
    //     return _playerDefense;
    // }

    // public int GetEnemyHP()
    // {
    //     return _enemyHealth;
    // }

    // public int GetEnemyATK()
    // {
    //     return _enemyAttack;
    // }

    // public int GetEnemyDEF()
    // {
    //     return _enemyDefense;
    // }
    private void SetStats()
    {
        SetPlayerHP(30);
        SetPlayerATK(5);
        SetPlayerDEF(2);
        SetEnemyHP(20);
        SetEnemyATK(7);
        SetEnemyDEF(2);
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