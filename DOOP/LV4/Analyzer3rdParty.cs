using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LV4
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int colCount = data[0].Length;
            int rowCount = data.Length;
            double[] results = new double[colCount];
            double sum = 0;
            for (int i = 0; i < colCount; i++)
            {
               for(int j=0;j<rowCount;j++)
                {
                    sum += data[j][i];
                }
                results[i] = sum / rowCount;
                sum = 0;
            }
            return results;
        }

    }
}
