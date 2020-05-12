using System;
using System.Collections.Generic;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. zadatak
            List<IRentable> rentables = new List<IRentable>();
            rentables.Add(new Book("Knjiga"));
            rentables.Add(new Video("Kazeta"));
            rentables.Add(new HotItem(new Video("HotFilm")));
            rentables.Add(new HotItem(new Book("HotBook")));
            List<IRentable> flashSale = new List<IRentable>();
            foreach(IRentable rentable in rentables)
            {
                flashSale.Add(new DiscountedItem(rentable, 25));
            }
            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(flashSale);
            printer.PrintTotalPrice(flashSale);
        }
    }
}
