using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class BlueTheme : ITheme
    {
        public string GetFooter(int width)
        {
            return new string('_', width);
        }

        public string GetHeader(int width)
        {
            return new string('+', width);
        }

        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }

        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
