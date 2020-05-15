using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class ShippingService
    {
        public double initialWeightPrice { get; private set; }
        public ShippingService()
        {
            this.initialWeightPrice = 5.99;
        }
        public double GetShippingPrice(IShipable item)
        {
            double packetMass = 0;
            packetMass = item.Weight;
            return packetMass * initialWeightPrice;
        }

    }
}
