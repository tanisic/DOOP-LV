using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class Direktor
    {
        public void ConstructConsoleNotificationINFO(IBuilder builder,string author)
        {          
            builder.SetAuthor(author).SetColor(ConsoleColor.Blue).SetLevel(Category.INFO)
                .SetTime(DateTime.Now).SetTitle("Naslov").SetText("Neki tekst");
        }
        public void ConstructConsoleNotificationALERT(IBuilder builder, string author)
        {
            builder.SetAuthor(author).SetColor(ConsoleColor.Yellow).SetLevel(Category.ALERT)
                .SetTime(DateTime.Now).SetTitle("Naslov").SetText("Neki tekst");
        }
        public void ConstructConsoleNotificationERROR(IBuilder builder, string author)
        {
            builder.SetAuthor(author).SetColor(ConsoleColor.DarkRed).SetLevel(Category.ERROR)
                .SetTime(DateTime.Now).SetTitle("Naslov").SetText("Neki tekst");
        }
    }
}
