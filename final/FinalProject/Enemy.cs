using System;

class Enemy : Encounter
{
    protected int enemyAction;

    public Enemy()
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
}