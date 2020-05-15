using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        { //3. zadatak
            VirtualProxyDataset virtualProxy = new VirtualProxyDataset(@"C:\Users\tin_k\Documents\DOOP-LV\DOOP\LV5\Test.csv");
            ProtectionProxyDataset protectionProxy = new ProtectionProxyDataset(User.GenerateUser("korisnik1"));
            DataConsolePrinter printer = new DataConsolePrinter();
            printer.PrintInConsole(virtualProxy);
            printer.PrintInConsole(protectionProxy);              
        }
    }
}
