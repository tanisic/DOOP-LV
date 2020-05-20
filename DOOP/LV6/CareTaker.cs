using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class CareTaker
    {
        public List<Memento> PreviousStates { get; set; }
        public CareTaker()
        {
            this.PreviousStates = new List<Memento>();
        }
        public void AddMemento(Memento memento)
        {
            PreviousStates.Add(memento);
        }
        public void RemoveMemento(Memento memento)
        {
            PreviousStates.Remove(memento);
        }
        public List<Memento> GetMementoList()
        {
            return this.PreviousStates;
        }
    }
}
