using System;

class Encounter
{
    protected int playerHealth;
    protected int playerAttack;
    protected int playerDefense;
    protected int enemyHealth;
    protected int enemyAttack;
    protected int enemyDefense;
    protected int healAmount;

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