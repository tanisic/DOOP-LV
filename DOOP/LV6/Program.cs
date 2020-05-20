using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace LV6
{
    class Program
    { //8. zadatak
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation(27);
            HomeThermostat thermostat1 = new HomeThermostat();
            HomeThermostat thermostat2 = new HomeThermostat();
            weatherStation.AddObserver(thermostat1);
            weatherStation.AddObserver(thermostat2);
            weatherStation.SetTemperature(10);
            weatherStation.SetTemperature(42);
            weatherStation.SetTemperature(20);
            weatherStation.RemoveObserver(thermostat2);
            weatherStation.SetTemperature(10);
            weatherStation.SetTemperature(42);
            weatherStation.SetTemperature(20);
        }
    }
}
