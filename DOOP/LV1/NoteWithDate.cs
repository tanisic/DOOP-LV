using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP
{
    class NoteWithDate:Note
    {
        public DateTime CreationDate { get; set; }

        public NoteWithDate(string Text, string Author, int Importance) : base(Text, Author, Importance)
        {
            CreationDate = DateTime.Now;
        }


        public void ChangeDateTime(DateTime Time) { this.CreationDate = Time; }
        public DateTime GetTime() { return this.CreationDate; }
        public override string ToString()
        {
            return "Date of creation: " + this.CreationDate + "\n" + base.ToString();
        }
    }
}
