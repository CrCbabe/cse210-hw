using System;

class Player : Encounter
{
    int playerAction;

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
}