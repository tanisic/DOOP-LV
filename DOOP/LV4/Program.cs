using System;
using System.Collections.Generic;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. zadatak
            UserValidator validator = new UserValidator();
            while (true) { 
            if(validator.IsUserEntryValid(UserEntry.ReadUserFromConsole()))
                {
                    Console.WriteLine("Login Successful!");
                    break;
                }
            }  
        }
    }
}
