using System;

namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {       //4. zadatak
            ConsoleLogger logger = new ConsoleLogger();
            DiceRoller diceRoller = new DiceRoller(logger);
            Random random = new Random();
            for(int i=0;i<20;i++)
            {
                diceRoller.InsertDie(new Die(6));
            }
            diceRoller.RollAllDice();
            diceRoller.LogRollingResults();
        }
    }
}
