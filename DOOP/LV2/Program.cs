using System;

namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {   //1.zadatak
            DiceRoller diceRoller = new DiceRoller();

            for(int i=0;i<20;i++)
            {
                diceRoller.InsertDie(new Die(6));
            }
            diceRoller.RollAllDice();
            foreach(int number in diceRoller.GetRollingResults())
            {
                Console.WriteLine(number);
            }
        }
    }
}
