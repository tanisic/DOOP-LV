using System;
using System.Data;
using System.Globalization;

namespace LV3
{
    class Program
    {   //6. zadatak
        static void Main(string[] args)
        {
            NotificationBuilder builder = new NotificationBuilder();
            Direktor direktor = new Direktor();
            NotificationManager manager = new NotificationManager();
            direktor.ConstructConsoleNotificationALERT(builder, "Ante");
            manager.Display(builder.Build());
            direktor.ConstructConsoleNotificationINFO(builder, "Ivan");
            manager.Display(builder.Build());
            direktor.ConstructConsoleNotificationERROR(builder, "Marin");
            manager.Display(builder.Build());
        }
    }
}
