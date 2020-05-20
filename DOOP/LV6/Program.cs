using System;
using System.Collections.Generic;

namespace LV6
{
    class Program
    { //4. zadatak
        static void Main(string[] args)
        {
            CareTaker careTaker = new CareTaker();
            BankAccount account = new BankAccount("owner1", "adress1", (decimal)50.25);
            careTaker.AddMemento(account.StoreState());
             account = new BankAccount("owner2", "adress2", (decimal)51.25);
            careTaker.AddMemento(account.StoreState());
            account = new BankAccount("owner3", "adress3", (decimal)55.25);
            careTaker.AddMemento(account.StoreState());
            foreach(BankAccountMemento memento in careTaker.GetMementoList())
            {
                account.RestoreState(memento);
                Console.WriteLine(account.ToString());
            }
        }
    }
}
