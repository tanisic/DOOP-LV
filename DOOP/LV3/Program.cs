using System;
using System.Data;
using System.Globalization;

namespace LV3
{
    class Program
    {   //5. zadatak
        static void Main(string[] args)
        {
            NotificationBuilder notification = new NotificationBuilder();
            NotificationManager manager = new NotificationManager();
            notification.SetAuthor("Autor");
            notification.SetColor(ConsoleColor.Yellow);
            notification.SetLevel(Category.ERROR);
            notification.SetText("Neki text");
            notification.SetTitle("Naslov");
            notification.SetTime(DateTime.Now);
            manager.Display(notification.Build());
        }
    }
}
