using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class LinearSearch : ISearchStrategy
    {
        public void Search(double[] array, double itemToFind)
        {
            int length = array.Length;
            bool flag = false;
            for(int i=0;i<length;i++)
            {
                if(array[i] == itemToFind)
                {
                    flag = true;
                    Console.WriteLine("Item " + itemToFind + " was found on " + i + " position");
                    
                }
            }
            if(!flag)
            {
                Console.WriteLine(itemToFind + " is not in array.");
            }
        }
    }
}
