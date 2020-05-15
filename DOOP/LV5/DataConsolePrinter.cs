using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5
{
    class DataConsolePrinter
    {
        public void PrintInConsole(IDataset dataset)
        {
            ReadOnlyCollection<List<string>> dataList = dataset.GetData();
            foreach(List<string> list in dataList)
            {
                foreach(string item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
