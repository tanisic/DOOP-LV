using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class GroupNote : Note
    {
        private List<string> names;
        public GroupNote(string message, ITheme theme) : base(message, theme)
        {
            this.names = new List<string>();
        }
        public void PrintNames()
        {
           foreach(string name in names)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine();
        }
        public void AddName(string name)
        {
            names.Add(name);
        }
        public void RemoveName(string name)
        {
            if(names.Contains(name))
            {
                names.Remove(name);
            }
        }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("REMINDER: ");   
            string framedMessage = this.GetFramedMessage();
            this.PrintNames();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}
