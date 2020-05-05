using System;
using System.Data;
using System.Globalization;

namespace LV3
{
    class Program
    {   //4. zadatak
        static void Main(string[] args)
        {
            ConsoleNotification notification = new ConsoleNotification("Ivan", "Naslov", "Nekakav tekst",
                DateTime.Now, Category.ALERT, ConsoleColor.Green);
            NotificationManager notificationManager = new NotificationManager();
            notificationManager.Display(notification);
        }
    }
}
