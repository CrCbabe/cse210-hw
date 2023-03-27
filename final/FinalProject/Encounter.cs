using System;

class Encounter
{
    protected int playerHealth = 30;
    protected int playerAttack = 5;
    protected int playerDefense = 2;
    protected int enemyHealth = 20;
    protected int enemyAttack = 7;
    protected int enemyDefense = 2;
    protected int healAmount = 3;

    public Encounter()
    {
        RunCombat();
        EndCombat();
    }

    void RunCombat()
    {
        while (playerHealth > 0 && enemyHealth > 0)
        {
            Player player = new Player();
            Enemy enemy = new Enemy();
        }
    }

    void EndCombat()
    {
        if (playerHealth > 0)
        {
            Console.WriteLine("Congratulations, you have won!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
    }
}