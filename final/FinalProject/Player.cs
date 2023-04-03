using System;

class Player : Encounter
{
    int playerAction;
    // int playerHealth = GetPlayerHP();
    // int enemyHealth = GetEnemyHP();

    public Player()
    {
        Console.WriteLine("-- Player Turn --");
        ChooseAction();
        Console.WriteLine($"Player HP - {_playerHealth}, Enemy HP - {_enemyHealth}");
    }
    void ChooseAction()
    {
        Console.WriteLine("You can attack (1) or use a skill (2).");
        playerAction = int.Parse(Console.ReadLine());
        if (playerAction == 1)
        {
            P_Attack attack = new P_Attack();
        }
        else
        {
            P_Skill skill = new P_Skill();
        }
    }

    public override void SetPlayerHP(int playerHP)
    {
        _playerHealth = playerHP;
    }

    public override void SetPlayerATK(int playerATK)
    {
        _playerAttack = playerATK;
    }

    public override void SetPlayerDEF(int playerDEF)
    {
        _playerDefense = playerDEF;
    }

    public override void SetEnemyHP(int enemyHP)
    {
        _enemyHealth = enemyHP;
    }

    public override void SetEnemyDEF(int enemyDEF)
    {
        _enemyDefense = enemyDEF;
    }
}