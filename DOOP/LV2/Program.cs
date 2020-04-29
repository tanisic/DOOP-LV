using System;

namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {       //5. zadatak
            ConsoleLogger logger = new ConsoleLogger();
            DiceRoller diceRoller = new DiceRoller();
            Random random = new Random();
            for(int i=0;i<20;i++)
            {
                diceRoller.InsertDie(new Die(6));
            }
            diceRoller.RollAllDice();
            logger.Log(diceRoller);
        }//6. zadatak: sučelje iz primjera sam razlomio na 2 sučelja IClosedDiceeRoller i ICompleteDiceRoller
    }
}
