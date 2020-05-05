using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LV3
{
    class Logger
    {
        private static Logger thisInstance;
        private string filePath;
        public Logger(string filePath)
        {
            this.filePath = filePath;
        }
        public static Logger GetInstance(string filePath)
        {
            if(thisInstance==null)
            {
                thisInstance = new Logger(filePath);
            }
            return thisInstance;
        }
        public void Log(string message)
        {
            using (StreamWriter stream = new StreamWriter(filePath, true))
            {
                stream.WriteLine(message);
            }

        }
    }
}
