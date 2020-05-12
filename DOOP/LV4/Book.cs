using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class Book : IRentable
    {   private readonly double BaseBookPrice = 3.99;
        public String Title { get; private set; }
        public string Description { get { return this.Title; } }
        public Book(string title)
        {
            this.Title = title;
        }
        public double CalculatePrice()
        {
            return this.BaseBookPrice;
        }
    }
}
