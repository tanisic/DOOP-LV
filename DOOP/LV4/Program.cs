using System;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset dataset = new Dataset(@"C:\Users\tin_k\Documents\DOOP-LV\DOOP\LV4\Test.csv");
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);
            double[] rowAverage = adapter.CalculateAveragePerRow(dataset);
            double[] colAverage = adapter.CalculateAveragePerColumn(dataset);
            Console.WriteLine("Rows average:");
            foreach(double item in rowAverage)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\nColumns average:");
            foreach (double item in colAverage)
            {
                Console.Write(" " + item);
            }
        }
    }
}
