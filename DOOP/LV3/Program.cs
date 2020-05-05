using System;

namespace LV3
{
    class Program
    {   //1. zadatak
        static void Main(string[] args)
        {   //duboko kloniranje
            Dataset datasetFile = new Dataset();
            datasetFile.LoadDataFromCSV(@"C:\Users\tin_k\Documents\DOOP-LV\DOOP\LV3\csvfile.csv");
            Dataset deepCopyData = (Dataset)datasetFile.Clone();          
            datasetFile.printDataset();
            deepCopyData.printDataset();
                       
        }
    }
}
