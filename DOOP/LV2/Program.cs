using System;

namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {   //2.zadatak
            DiceRoller diceRoller = new DiceRoller();
            Random random = new Random();
            for(int i=0;i<20;i++)
            {
                diceRoller.InsertDie(new Die(6,random));
            }
            diceRoller.RollAllDice();
            diceRoller.PrintRollingResults();
        }
    }
}
