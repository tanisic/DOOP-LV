using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    interface ICompleteDiceRoller:IClosedDiceRoller
    {
        void InsertDie(Die die);
        void RemoveAllDice();       
    }
}
