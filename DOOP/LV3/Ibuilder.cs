using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    interface Ibuilder
    {
        ConsoleNotification Build();
        Ibuilder SetAuthor(String author);
        Ibuilder SetTitle(String title);
        Ibuilder SetTime(DateTime time);
        Ibuilder SetLevel(Category level);
        Ibuilder SetColor(ConsoleColor color);
        Ibuilder SetText(String text);
    }
}
