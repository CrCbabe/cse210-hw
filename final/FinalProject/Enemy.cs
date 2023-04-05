using System;

class Enemy
{

    private int enemyAction;

    public Enemy(int enemyHP, int enemyATK, int enemyDEF, int playerHP, int playerDEF)
    {
        Console.WriteLine("-- Enemy Turn --");
        enemyAction = ChooseRandomAction();
        RunEnemyAction(enemyAction, enemyHP, enemyATK, enemyDEF, playerHP, playerDEF);
        Console.WriteLine($"Player HP - {playerHP}, Enemy HP - {enemyHP}");
    }

    private int ChooseRandomAction()
    {
        Random random = new Random();
        enemyAction = random.Next(0, 10);
        return enemyAction;
    }

    private void RunEnemyAction(int enemyAction, int enemyHP, int enemyATK, int enemyDEF, int playerHP, int playerDEF)
    {
        if (enemyAction <= 5)
        {
            Attack attack = new Attack(enemyATK, playerDEF, playerHP, "Enemy");
        }
        else if (enemyAction == 6)
        {
            Heal heal = new Heal(enemyHP, "Enemy");
        }
        else if (enemyAction == 7)
        {
            Guard guard = new Guard(enemyDEF, "Enemy");
        }
        else if (enemyAction == 8)
        {
            Focus focus = new Focus(enemyATK, "Enemy");
        }
        else if (enemyAction == 9)
        {
            Distract distract = new Distract(playerDEF, "Enemy", "Player");
        }
    }
}