using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace LV6
{
    class Program
    { //9. zadatak
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation(21);
            weatherStation.AddObserver(new Car(240, 30, Tire.WINTER));
            weatherStation.SetTemperature(0);
            weatherStation.SetTemperature(7);


        }
    }
}
