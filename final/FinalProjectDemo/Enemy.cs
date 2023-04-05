using System;

class Enemy : Encounter
{
    protected int enemyAction;
    // int playerHealth = GetPlayerHP();
    // int enemyHealth = GetEnemyHP();

    // public Enemy()
    // {
    //     Console.WriteLine("inside of enemy constructor!");
    //     Start();


    // }

    public void Begin()
    {
        if (_enemyHealth > 0)
        {
            Console.WriteLine("-- Enemy Turn --");
            enemyAction = ChooseRandomAction();
            if (enemyAction == 0 || enemyAction == 3)
            {
                E_Attack attack = new E_Attack();
            }
            else
            {
                E_Skill skill = new E_Skill();
            }
            Console.WriteLine($"Player HP - {_playerHealth}, Enemy HP - {_enemyHealth}");
        }
    }
    protected int ChooseRandomAction()
    {
        Random random = new Random();
        enemyAction = random.Next(0, 4);
        return enemyAction;
    }

    public override void SetPlayerHP(int playerHP)
    {
        _playerHealth = playerHP;
    }

    public override void SetPlayerDEF(int playerDEF)
    {
        _playerDefense = playerDEF;
    }

    public override void SetEnemyHP(int enemyHP)
    {
        _enemyHealth = enemyHP;
    }

    public override void SetEnemyATK(int enemyATK)
    {
        _enemyAttack = enemyATK;
    }

    public override void SetEnemyDEF(int enemyDEF)
    {
        _enemyDefense = enemyDEF;
    }
}