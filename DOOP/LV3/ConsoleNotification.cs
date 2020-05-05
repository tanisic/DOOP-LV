﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    public enum Category { ERROR, ALERT, INFO }


    class ConsoleNotification:Prototype
    {
        public String Author { get; private set; }
        public String Title { get; private set; }
        public String Text { get; private set; }
        public DateTime Timestamp { get; private set; }
        public Category Level { get; private set; }
        public ConsoleColor Color { get; private set; }
        public ConsoleNotification(String author, String title,
        String text, DateTime time, Category level, ConsoleColor color)
        {
            this.Author = author;
            this.Title = title;
            this.Text = text;
            this.Timestamp = time;
            this.Level = level;
            this.Color = color;
        }
        /*7. zadatak  Odgovor: U konkretnom slučaju mislim da ima razlike između deep i shallow kopije
         * zbog toga što sa shallow kopijom i dalje možemo mjenjati vrijednosti originala i kopije,
         * dok kod deep kopije radimo novi objekt i nezavisan je od svog originala.
        */
        public Prototype Clone()
        {
            return (ConsoleNotification)this.MemberwiseClone();
        }
    }
}
