using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class CareTaker
    {
        public List<BankAccountMemento> PreviousStates { get; set; }
        public CareTaker()
        {
            this.PreviousStates = new List<BankAccountMemento>();
        }
        public void AddMemento(BankAccountMemento memento)
        {
            PreviousStates.Add(memento);
        }
        public void RemoveMemento(BankAccountMemento memento)
        {
            PreviousStates.Remove(memento);
        }
        public List<BankAccountMemento> GetMementoList()
        {
            return this.PreviousStates;
        }
    }
}
