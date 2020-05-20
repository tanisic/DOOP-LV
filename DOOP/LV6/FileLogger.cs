using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LV6
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            using (StreamWriter stream = new StreamWriter(filePath, true))
            {
                stream.WriteLine(type + ": " + message + "\nCreation time: " + DateTime.Now);
            }             
        }
    }
}
