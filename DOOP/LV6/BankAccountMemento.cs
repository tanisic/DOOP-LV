using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class BankAccountMemento
    {
        public string ownerName;
        public string ownerAddress;
        public decimal balance;
        public BankAccountMemento(string ownerName,string ownerAdress,decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAdress;
            this.balance = balance;
        }
    }
}
