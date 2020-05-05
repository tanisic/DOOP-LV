using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Text;

namespace LV3
{
    class MatrixGenerator
    {
        private static MatrixGenerator thisInstance;
        private Random random;
        
        private MatrixGenerator()
        {
            this.random = new Random();
        }
        public static MatrixGenerator GetInstance()
        {
            if(thisInstance==null)
            {
                thisInstance = new MatrixGenerator();
            }
            return thisInstance;
        }
        public double[,] GenerateMatrix(int rows,int columns)
        {
            double[,] matrix = new double[rows,columns];
            for(int i=0;i<rows;i++)
            {   for(int j=0;j<columns;j++)
                {
                    matrix[i,j] = random.NextDouble();
                }
            }
            return matrix;
        }

    }
}
