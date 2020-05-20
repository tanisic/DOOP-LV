using System;
using System.Collections.Generic;

namespace LV6
{
    class Program
    { //3. zadatak
        static void Main(string[] args)
        {
            ToDoItem item1 = new ToDoItem("title1", "text1", DateTime.Today);
            CareTaker careTaker = new CareTaker();
            careTaker.AddMemento(item1.StoreState());
            item1 = new ToDoItem("title2", "text2", DateTime.Today);
            careTaker.AddMemento(item1.StoreState());
            item1 = new ToDoItem("title3","text3",DateTime.Today);
            careTaker.AddMemento(item1.StoreState());
            foreach(Memento memento in careTaker.GetMementoList())
            {
                item1.RestoreState(memento);
                Console.WriteLine(item1.ToString());
            }
        }
    }
}
