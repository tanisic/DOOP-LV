using System;
using System.Data;
using System.Globalization;

namespace LV3
{
    class Program
    {   //2. zadatak
        static void Main(string[] args)
        {
            MatrixGenerator matrixGenerator = MatrixGenerator.GetInstance();
            double[,] matrix = matrixGenerator.GenerateMatrix(7, 7);
             for(int i=0;i<7;i++)
            {
                for(int j=0;j<7;j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }    
        }
    }
}
