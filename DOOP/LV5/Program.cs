using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        { //4. zadatak
            ReminderNote reminder = new ReminderNote("Vazna poruka", new BlueTheme());
            reminder.Show();
        }
    }
}
