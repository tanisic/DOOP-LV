using System;
using System.Collections.Generic;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. zadatak
            string[] passwords = { "adE2f2", "aE2f5", "fg2ghh31" };
            string[] emails = { "test1@etfos.hr", "test@ferit.tk", "test2@etfos.com" };
            PasswordValidator passwordValidator = new PasswordValidator(6);
            EmailValidator emailValidator = new EmailValidator();
            Console.WriteLine("Passwords: ");
            foreach(string password in passwords)
            {
                Console.WriteLine(passwordValidator.IsValidPassword(password));
            }
            Console.WriteLine("E-mails: ");
            foreach (string email in emails)
            {
                Console.WriteLine(emailValidator.IsValidAddress(email));
            }
        }
    }
}
