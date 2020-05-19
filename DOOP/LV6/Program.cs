using System;
using System.Collections.Generic;

namespace LV6
{
    class Program
    { //2. zadatak
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            for(int i=0;i<3;i++)
            {
                products.Add(new Product("description",72.05));
            }
            Box box = new Box(products);
            ProductIterator iterator = (ProductIterator)box.GetIterator();
            while(!iterator.IsDone)
            {
                Console.WriteLine(iterator.Current.ToString());
                iterator.Next();
            }
        }
    }
}
