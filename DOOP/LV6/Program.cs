using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace LV6
{
    class Program
    { //6. zadatak
        static void Main(string[] args)
        {  string toCheck = "Ab0";
            StringChecker checker = new StringLengthChecker();
            checker.Check(toCheck);
            checker.SetNext(new StringLowerCaseChecker());
            checker.Check(toCheck);
            checker.SetNext(new StringUpperCaseChecker());
            checker.Check(toCheck);
            checker.SetNext(new StringDigitChecker());
            Console.WriteLine(checker.Check(toCheck));

        }
    }
}
