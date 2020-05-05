using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class NotificationBuilder : IBuilder
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

        public IBuilder SetAuthor(string author)
        {
            this.Author = author; return this;
        }

        public IBuilder SetColor(ConsoleColor color)
        {
            this.Color = color; return this;
        }

        public IBuilder SetLevel(Category level)
        {
            this.Level = level; return this;
        }

        public IBuilder SetText(string text)
        {
            this.Text = text; return this;
        }

        public IBuilder SetTime(DateTime time)
        {
            this.Timestamp = time; return this;
        }

        public IBuilder SetTitle(string title)
        {
            this.Title = title; return this;
        }
    }
}
