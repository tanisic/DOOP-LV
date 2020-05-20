using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace LV6
{
    class Program
    { //5. zadatak
        static void Main(string[] args)
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger =
              new FileLogger(MessageType.ERROR | MessageType.WARNING, @"C:\Users\tin_k\Documents\DOOP-LV\DOOP\LV6\logFile.txt");
            logger.Log("poruka1", MessageType.ERROR | MessageType.WARNING);
            fileLogger.Log("message1", MessageType.ALL);

        }
    }
}
