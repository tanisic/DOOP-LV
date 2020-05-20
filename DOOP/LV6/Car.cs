using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{   enum Tire
    {
        SUMMER,
        WINTER,
    }

    class Car : WeatherObserver
    {
        private double enginePower;
        private double fuelInLiters;
        private Tire tires;
        const int changeTemperature = 5;
        public Car(double power, double fuel, Tire tires)
        {
            this.enginePower = power;
            this.fuelInLiters = fuel;
            this.tires = tires;
        }
        public void Update(int temperature)
        {
            if (temperature > changeTemperature)
            {
                this.ChangeTiresToSummer();
            }
            else if(temperature<changeTemperature)
            {
                this.ChangeTiresToWinter();
            }
        }
        private void ChangeTiresToWinter()
        {
            Console.WriteLine("Changing to winter tires."); this.tires = Tire.WINTER;
        }
        private void ChangeTiresToSummer()
        {
            Console.WriteLine("Changing to summer tires."); this.tires = Tire.SUMMER;
        }
    }
}
