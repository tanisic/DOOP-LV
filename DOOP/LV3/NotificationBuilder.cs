using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class NotificationBuilder : Ibuilder
    {
        private string Author;
        private string Title;
        private string Text;
        private DateTime Timestamp;
        private Category Level;
        private ConsoleColor Color;

        public ConsoleNotification Build()
        {
            return new ConsoleNotification(Author, Title, Text, Timestamp, Level, Color);
        }

        public Ibuilder SetAuthor(string author)
        {
            this.Author = author; return this;
        }

        public Ibuilder SetColor(ConsoleColor color)
        {
            this.Color = color; return this;
        }

        public Ibuilder SetLevel(Category level)
        {
            this.Level = level; return this;
        }

        public Ibuilder SetText(string text)
        {
            this.Text = text; return this;
        }

        public Ibuilder SetTime(DateTime time)
        {
            this.Timestamp = time; return this;
        }

        public Ibuilder SetTitle(string title)
        {
            this.Title = title; return this;
        }
    }
}
