using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP
{
    enum Importance
    {
        Low, Medium, High
    }
    class Note
    {
        private string Text;
        private string Author;
        private Importance Importance;

        public string GetText() { return this.Text; }
        public void SetText(string text) { this.Text = text; }
        public string GetAuthor() { return this.Author; }
        public Importance GetImportance() { return this.Importance; }
        public void SetImportance(int Importance) { this.Importance = (Importance)Importance; }


        public Note(string Author)
        {
            this.Text = string.Empty;
            this.Author = Author;
            Importance = Importance.Low;
        }
        public Note()
        {
            this.Text = string.Empty;
            this.Author = string.Empty;
            Importance = Importance.Low;
        }
        public Note(string Text, string Author, int Importance)
        {
            this.Text = Text;
            this.Author = Author;
            this.Importance = (Importance)Importance;
        }

        public override string ToString()
        {
            return "Author: " + GetAuthor() + "\nText: " + GetText() + "\n";
        }
    }
}
