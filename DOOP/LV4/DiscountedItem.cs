using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class DiscountedItem : RentableDecorator
    {   public double discountPercentage { get; private set; }
        public DiscountedItem(IRentable rentable,double discount) : base(rentable)
        {
            this.discountPercentage = discount;
        }
        public override double CalculatePrice()
        {
            double discount = base.CalculatePrice() * discountPercentage / 100.0;
            return base.CalculatePrice()-discount;
        }
        public override String Description
        {
            get
            {
                return "now at "+this.discountPercentage+"% off!  " + base.Description;
            }
        }
    }
}
