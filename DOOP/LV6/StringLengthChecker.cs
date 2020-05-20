using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class StringLengthChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            int minimumLength = 3;
            if (stringToCheck.Length >= minimumLength)
            {
                return true;
            }
            else return false;
        }
    }
}
