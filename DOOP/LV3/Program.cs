using System;
using System.Data;
using System.Globalization;

namespace LV3
{
    class Program
    {   //3. zadatak
        static void Main(string[] args)
        {
            Logger logger = Logger.GetInstance(@"C:\Users\tin_k\Documents\DOOP-LV\DOOP\LV3\LoggerOutput.txt");
            string message = "Poruka za log file.";
            logger.Log(message);
        }
    }
}
