using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        { //7. zadatak
            double[] array = {5,6,2,8,9,77,51,21,66,75,42,89,21,75,34};
            NumberSequence numberSequence = new NumberSequence(array);
            LinearSearch linearSearch=new LinearSearch();
            numberSequence.SetSearchStrategy(linearSearch);
            numberSequence.Search(75);
            
        }
    }
}
