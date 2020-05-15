using System;

namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box= new Box("kutija1");
            box.Add(new Product("proizvod1", 6.7, 15.2));
            box.Add(new Product("proizvod2", 15.1, 5.6));
            box.Add(new Product("proizvod3", 4.2, 7.8));
            ShippingService shippingService = new ShippingService();
            Console.WriteLine("Cijena slanja paketa je :"+shippingService.GetShippingPrice(box));
        }
    }
}
